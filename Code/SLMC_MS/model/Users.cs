using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLMC_MS.model
{
    class Users:user
    {
        public static String GetPassword(String userID)
        {
            using (slmc db = new slmc())
            {
                user myUser = db.user.FirstOrDefault(i => i.username.Equals(userID) && i.disabled.Equals("N"));
                if (myUser == null)
                    return null;
                else
                    return myUser.password;
            }
        }

        public static List<user> GetUsers()
        {
            using (slmc db = new slmc())
            {
                var users = db.user.Select(i => i);
                return users.ToList();
            }
        }

        public static user GetUser(String userID)
        {
            using (slmc db = new slmc())
            {
                user myUser = db.user.FirstOrDefault(i => i.username.Equals(userID));
                return myUser;
            }
        }

        public static staff GetStaff(user myUser)
        {
            using (slmc db = new slmc())
            {
                staff myStaff = db.staff.FirstOrDefault(i => i.staffID.Equals(myUser.staffID));
                return myStaff;
            }
        }

        public static String GetPositionID(user myUser)
        {
            using (slmc db = new slmc())
            {
                staff myStaff = db.staff.FirstOrDefault(i => i.staffID.Equals(myUser.staffID));
                if (myStaff != null)
                    return myStaff.positionID;
                else
                    return null;
            }
        }

        public static List<user> FindUser(String catagory, String username, String disabled)
        {
            using (slmc db = new slmc())
            {
                if (!catagory.Equals("") && !disabled.Equals("")) 
                {
                    var users = db.user.Where(i => i.category.Equals(catagory) && i.username.Contains(username) && i.disabled.Equals(disabled)).Select(i => i);
                    return users.ToList();
                }
                else if(catagory.Equals("") && disabled.Equals(""))
                {
                    var users = db.user.Where(i => i.username.Contains(username)).Select(i => i);
                    return users.ToList();
                }
                else if(catagory.Equals(""))
                {
                    var users = db.user.Where(i => i.username.Contains(username) && i.disabled.Equals(disabled)).Select(i => i);
                    return users.ToList();
                } else
                {
                    var users = db.user.Where(i => i.category.Equals(catagory) && i.username.Contains(username)).Select(i => i);
                    return users.ToList();
                }
            }
        }

        public static void SetPassword(String username, String password)
        {
            using (slmc db = new slmc())
            {
                user myUser = db.user.FirstOrDefault(i => i.username.Equals(username));
                myUser.password = password;
                db.SaveChanges();
            }
        }

        public static void Disable(String username)
        {
            using (slmc db = new slmc())
            {
                user myUser = db.user.FirstOrDefault(i => i.username.Equals(username));
                myUser.disabled = "Y";
                db.SaveChanges();
            }
        }

        public static void Enable(String username)
        {
            using (slmc db = new slmc())
            {
                user myUser = db.user.FirstOrDefault(i => i.username.Equals(username));
                myUser.disabled = "N";
                db.SaveChanges();
            }
        }

    }
}
