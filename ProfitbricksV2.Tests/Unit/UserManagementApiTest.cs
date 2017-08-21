using Api;
using Client;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitBricksSDK.Tests
{
    [TestClass]
    public class UserManagementApiTest
    {
        GroupApi groupApi = new GroupApi(Config.Configuration);
        UserApi userApi = new UserApi(Config.Configuration);
        ShareApi shareApi = new ShareApi(Config.Configuration);
        ResourceApi resourceApi = new ResourceApi(Config.Configuration);
        static Group group;
        static User user;
        static Share share;

        DataCenterApi dcApi = new DataCenterApi(Config.Configuration);
        VolumeApi volumeApi = new VolumeApi(Config.Configuration);
        SnapshotApi snapshotApi = new SnapshotApi(Config.Configuration);
        IPBlocksApi ipApi = new IPBlocksApi(Config.Configuration);
        static Datacenter datacenter;
        static ManagedResource image;
        static Snapshot snapshot;
        static IpBlock ipBlock;

        private void createTestResources()
        {
            datacenter = new Datacenter
            {
                Properties = new DatacenterProperties
                {
                    Name = Config.DefaultName,
                    Location = Config.DefaultLocation
                },
                Entities = new DatacenterEntities
                {
                    Volumes = TestHelper.BuildVolumes()
                }
            };

            datacenter = dcApi.Create(datacenter, depth: 1);
            Config.DoWait(datacenter.Request);

            ipBlock = new IpBlock
            {
                Properties = new IpBlockProperties
                {
                    Name = Config.DefaultName,
                    Location = Config.DefaultLocation,
                    Size = 1
                }
            };
            ipBlock = ipApi.Create(ipBlock, depth: 1);
            Config.DoWait(ipBlock.Request);

            snapshot = volumeApi.CreateSnapshot(datacenter.Id, datacenter.Entities.Volumes.Items[0].Id, Config.DefaultName);
            Config.DoWait(snapshot.Request);
        }

        private void deleteTestResources()
        {
            if (snapshot != null)
            {
                var resp = snapshotApi.Delete(snapshot.Id);
                Assert.IsNull(resp);
                snapshot = null;
            }
            if (datacenter != null)
            {
                var resp = dcApi.Delete(datacenter.Id);
                Assert.IsNull(resp);
                datacenter = null;
            }
            if (ipBlock != null)
            {
                var resp = ipApi.Delete(ipBlock.Id);
                Assert.IsNull(resp);
                ipBlock = null;
            }
        }

        #region User API tests

        [TestMethod]
        public void UserCreate()
        {
            string email = string.Format("no-reply{0}@example.com", new Random().Next(0, int.MaxValue));

            user = new User
            {
                Properties = new UserProperties
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Email = email,
                    Password = string.Format("secretpassword{0}", new Random().Next(0, int.MaxValue)),
                    Administrator = true,
                    ForceSecAuth = false
                }
            };

            user = userApi.Create(user, depth: 5);

            Assert.AreEqual("user", user.Type);
            Assert.AreEqual("John", user.Properties.FirstName);
            Assert.AreEqual("Doe", user.Properties.LastName);
            Assert.AreEqual(email, user.Properties.Email);
            Assert.IsTrue(user.Properties.Administrator.Value);
        }

        [TestMethod]
        public void UserGet()
        {
            var resp = userApi.FindById(user.Id, depth: 1);

            Assert.AreEqual(user.Id, resp.Id);
            Assert.AreEqual(user.Type, resp.Type);
            Assert.AreEqual(user.Properties.FirstName, resp.Properties.FirstName);
            Assert.AreEqual(user.Properties.LastName, resp.Properties.LastName);
            Assert.AreEqual(user.Properties.Email, resp.Properties.Email);
            Assert.IsTrue(resp.Properties.Administrator.Value);
            Assert.IsFalse(resp.Properties.ForceSecAuth.Value);
            Assert.IsFalse(resp.Properties.SecAuthActive.Value);
            user = resp;
        }

        [TestMethod]
        [ExpectedException(typeof(ApiException))]
        public void UserCreateFail()
        {
            try
            {
                var req = new User
                {
                    Properties = new UserProperties
                    {
                        FirstName = "John",
                        LastName = "Doe",
                        Password = "secretpassword123"
                    }
                };
                userApi.Create(req);
            }
            catch (ApiException e)
            {
                Assert.IsTrue(e.Message.Contains(string.Format(Config.MissingAttributeError, "email")));
                throw;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ApiException))]
        public void UserGetFail()
        {
            try
            {
                userApi.FindById("00000000-0000-0000-0000-000000000000");
            }
            catch (ApiException e)
            {
                Assert.IsTrue(e.Message.Contains(Config.NotFoundError));
                throw;
            }
        }

        [TestMethod]
        public void UserList()
        {
            var list = userApi.FindAll();
            Assert.IsTrue(list.Items.Count > 0);
            Assert.AreEqual("user", list.Items[0].Type);
        }

        [TestMethod]
        public void UserUpdate()
        {
            var req = new User
            {
                Properties = new UserProperties
                {
                    FirstName = user.Properties.FirstName,
                    LastName = user.Properties.LastName,
                    Email = user.Properties.Email,
                    Administrator = false,
                    ForceSecAuth = false
                }
            };
            var resp = userApi.Update(user.Id, req);

            Assert.AreEqual(user.Id, resp.Id);
            Assert.AreEqual(user.Type, resp.Type);
            Assert.AreEqual(user.Properties.FirstName, resp.Properties.FirstName);
            Assert.AreEqual(user.Properties.LastName, resp.Properties.LastName);
            Assert.AreEqual(user.Properties.Email, resp.Properties.Email);
            Assert.IsFalse(resp.Properties.ForceSecAuth.Value);
            Assert.IsFalse(resp.Properties.SecAuthActive.Value);
            Assert.IsFalse(resp.Properties.Administrator.Value);
        }

        [TestMethod]
        public void UserDelete()
        {
            var resp = userApi.Delete(user.Id);
            Assert.IsNull(resp);
        }

        #endregion

        #region Group API tests

        [TestMethod]
        public void GroupCreate()
        {
            group = new Group
            {
                Properties = new GroupProperties
                {
                    Name = Config.DefaultName,
                    CreateDataCenter = true,
                    CreateSnapshot = true,
                    ReserveIp = true,
                    AccessActivityLog = true
                }
            };

            group = groupApi.Create(group, depth: 5);

            Assert.AreEqual("group", group.Type);
            Assert.AreEqual(Config.DefaultName, group.Properties.Name);
            Assert.IsTrue(group.Properties.CreateDataCenter.Value);
            Assert.IsTrue(group.Properties.CreateSnapshot.Value);
            Assert.IsTrue(group.Properties.ReserveIp.Value);
            Assert.IsTrue(group.Properties.AccessActivityLog.Value);
        }

        [TestMethod]
        public void GroupGet()
        {
            var resp = groupApi.FindById(group.Id, depth: 1);

            Assert.AreEqual(group.Id, resp.Id);
            Assert.AreEqual(group.Type, resp.Type);
            Assert.AreEqual(group.Properties.Name, resp.Properties.Name);
            Assert.AreEqual(group.Properties.CreateDataCenter, resp.Properties.CreateDataCenter);
            Assert.AreEqual(group.Properties.CreateSnapshot, resp.Properties.CreateSnapshot);
            Assert.AreEqual(group.Properties.ReserveIp, resp.Properties.ReserveIp);
            Assert.AreEqual(group.Properties.AccessActivityLog, resp.Properties.AccessActivityLog);
        }

        [TestMethod]
        [ExpectedException(typeof(ApiException))]
        public void GroupCreateFail()
        {
            try
            {
                var req = new Group
                {
                    Properties = new GroupProperties
                    {
                        CreateDataCenter = true
                    }
                };
                groupApi.Create(req);
            }
            catch (ApiException e)
            {
                Assert.IsTrue(e.Message.Contains(string.Format(Config.MissingAttributeError, "name")));
                throw;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ApiException))]
        public void GroupGetFail()
        {
            try
            {
                groupApi.FindById("00000000-0000-0000-0000-000000000000");
            }
            catch (ApiException e)
            {
                Assert.IsTrue(e.Message.Contains(Config.NotFoundError));
                throw;
            }
        }

        [TestMethod]
        public void GroupList()
        {
            var list = groupApi.FindAll();
            Assert.IsTrue(list.Items.Count > 0);
            Assert.AreEqual("group", list.Items[0].Type);
        }

        [TestMethod]
        public void GroupUpdate()
        {
            var req = new Group
            {
                Properties = new GroupProperties
                {
                    Name = group.Properties.Name + " - RENAME",
                    CreateDataCenter = false
                }
            };
            var resp = groupApi.Update(group.Id, req);

            Assert.AreEqual(group.Id, resp.Id);
            Assert.AreEqual(group.Type, resp.Type);
            Assert.AreEqual(group.Properties.Name + " - RENAME", resp.Properties.Name);
            Assert.IsFalse(resp.Properties.CreateDataCenter.Value);
        }

        [TestMethod]
        public void GroupUserAdd()
        {
            var resp = groupApi.AddGroupUser(group.Id, user.Id);
            Assert.AreEqual(user.Id, resp.Id);
            Assert.AreEqual(user.Type, resp.Type);
        }

        [TestMethod]
        public void GroupUserList()
        {
            var list = groupApi.FindAllGroupUsers(group.Id);
            Assert.IsTrue(list.Items.Count > 0);
            Assert.AreEqual("user", list.Items[0].Type);
        }

        [TestMethod]
        public void GroupUserRemove()
        {
            var resp = groupApi.RemoveGroupUser(group.Id, user.Id);
            Assert.IsNull(resp);
        }

        [TestMethod]
        public void GroupDelete()
        {
            var resp = groupApi.Delete(group.Id);
            Assert.IsNull(resp);

            deleteTestResources();
        }

        #endregion

        #region Resource API tests

        [TestMethod]
        public void ResourcesListAll()
        {
            createTestResources();

            var list = resourceApi.FindAll(depth: 0);
            Assert.IsTrue(list.Items.Count > 0);
            Assert.AreEqual("resources", list.Id);
            Assert.AreEqual("collection", list.Type);
        }

        [TestMethod]
        public void ResourcesListDataCenters()
        {
            var list = resourceApi.FindAllByType(ResourceType.datacenter);
            Assert.IsTrue(list.Items.Count > 0);
            Assert.AreEqual("resources", list.Id);
            Assert.AreEqual("datacenter", list.Items[0].Type);
        }

        [TestMethod]
        public void ResourcesGetDataCenter()
        {
            var resp = resourceApi.FindSpecificByType(ResourceType.datacenter, datacenter.Id);
            Assert.AreEqual(datacenter.Id, resp.Id);
            Assert.AreEqual("datacenter", resp.Type);
        }

        [TestMethod]
        [ExpectedException(typeof(ApiException))]
        public void ResourcesGetDataCenterFail()
        {
            try
            {
                resourceApi.FindSpecificByType(ResourceType.datacenter, "00000000-0000-0000-0000-000000000000");
            }
            catch (ApiException e)
            {
                Assert.IsTrue(e.Message.Contains(Config.NotFoundError));
                throw;
            }
        }

        [TestMethod]
        public void ResourcesListImages()
        {
            var list = resourceApi.FindAllByType(ResourceType.image);
            Assert.IsTrue(list.Items.Count > 0);
            Assert.AreEqual("resources", list.Id);
            Assert.AreEqual("image", list.Items[0].Type);
            image = list.Items[0];
        }

        [TestMethod]
        public void ResourcesGetImage()
        {
            var resp = resourceApi.FindSpecificByType(ResourceType.image, image.Id);
            Assert.AreEqual(image.Id, resp.Id);
            Assert.AreEqual("image", resp.Type);
        }

        [TestMethod]
        public void ResourcesListIpBlocs()
        {
            var list = resourceApi.FindAllByType(ResourceType.ipblock);
            Assert.IsTrue(list.Items.Count > 0);
            Assert.AreEqual("resources", list.Id);
            Assert.AreEqual("ipblock", list.Items[0].Type);
        }

        [TestMethod]
        public void ResourcesGetIpBlock()
        {
            var resp = resourceApi.FindSpecificByType(ResourceType.ipblock, ipBlock.Id);
            Assert.AreEqual(ipBlock.Id, resp.Id);
            Assert.AreEqual("ipblock", resp.Type);
        }

        [TestMethod]
        public void ResourcesListSnapshots()
        {
            var list = resourceApi.FindAllByType(ResourceType.snapshot);
            Assert.IsTrue(list.Items.Count > 0);
            Assert.AreEqual("resources", list.Id);
            Assert.AreEqual("snapshot", list.Items[0].Type);
        }

        [TestMethod]
        public void ResourcesGetSnapshot()
        {
            var resp = resourceApi.FindSpecificByType(ResourceType.snapshot, snapshot.Id);
            Assert.AreEqual(snapshot.Id, resp.Id);
            Assert.AreEqual("snapshot", resp.Type);
        }

        #endregion

        #region Share API tests

        [TestMethod]
        public void ShareCreate()
        {
            share = new Share
            {
                Properties = new ShareProperties
                {
                    EditPrivilege = true,
                    SharePrivilege = true
                }
            };

            share = shareApi.Add(group.Id, datacenter.Id, share);

            Assert.AreEqual("resource", share.Type);
            Assert.IsTrue(share.Properties.EditPrivilege.Value);
            Assert.IsTrue(share.Properties.SharePrivilege.Value);
        }

        [TestMethod]
        public void ShareGet()
        {
            var resp = shareApi.FindById(group.Id, share.Id, depth: 1);

            Assert.AreEqual(share.Id, resp.Id);
            Assert.AreEqual(share.Type, resp.Type);
            Assert.AreEqual(share.Properties.EditPrivilege, resp.Properties.EditPrivilege);
            Assert.AreEqual(share.Properties.SharePrivilege, resp.Properties.SharePrivilege);
        }

        [TestMethod]
        [ExpectedException(typeof(ApiException))]
        public void ShareCreateFail()
        {
            try
            {
                var req = new Share
                {
                    Properties = new ShareProperties()
                };
                shareApi.Add(group.Id, "00000000-0000-0000-0000-000000000000", req);
            }
            catch (ApiException e)
            {
                Assert.IsTrue(e.Message.Contains(Config.NotFoundError));
                throw;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ApiException))]
        public void ShareGetFail()
        {
            try
            {
                shareApi.FindById(group.Id, "00000000-0000-0000-0000-000000000000");
            }
            catch (ApiException e)
            {
                Assert.IsTrue(e.Message.Contains(Config.NotFoundError));
                throw;
            }
        }

        [TestMethod]
        public void ShareList()
        {
            var list = shareApi.FindAll(group.Id);
            Assert.IsTrue(list.Items.Count > 0);
            Assert.AreEqual("resource", list.Items[0].Type);
        }

        [TestMethod]
        public void ShareUpdate()
        {
            var req = new Share
            {
                Properties = new ShareProperties
                {
                    EditPrivilege = false
                }
            };
            var resp = shareApi.Update(group.Id, share.Id, req);

            Assert.AreEqual(share.Id, resp.Id);
            Assert.AreEqual(share.Type, resp.Type);
            Assert.IsFalse(resp.Properties.EditPrivilege.Value);
        }

        [TestMethod]
        public void ShareDelete()
        {
            var resp = shareApi.Remove(group.Id, share.Id);
            Assert.IsNull(resp);
        }

        #endregion
    }
}
