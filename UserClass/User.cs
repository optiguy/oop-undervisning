using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Optiguy
{
    public class User
    {

        #region fields
            private string username;
            private string firstname;
            private string lastname;
            private string password;
            private int role;
        #endregion

        #region constructor
            /// <summary>
            /// Konstruerer en bruger og sætter værdier til de fire fields
            /// </summary>
            /// <param name="username">Skriv brugerens brugernavn</param>
            /// <param name="firstname">Skriv brugerens fornavn</param>
            /// <param name="lastname">Skriv brugerens efternavn</param>
            /// <param name="role">Skriv brugerens rolle</param>
            public User(string username = "Guest", string firstname = "Guest", string lastname = "User", string password = "", int role = 3)
            {
                this.username = username;
                this.firstname = firstname;
                this.lastname = lastname;
                this.password = password;
                this.role = role;
            }
        #endregion
        
        #region properties
            public string Username { get { return this.username; } }
            public string Firstname { get { return this.firstname; } }
            public string Lastname { get { return this.lastname; } }
            public string Password { get { return this.password; } }
            public int Role { get { return this.role; } set { this.role = value; } }
        #endregion

        #region methods
            public static bool IsUser()
            {
                return HttpContext.Current.Session["user"] != null ? true : false;
            }

            public static void CreateSession(User user)
            {
                if(!IsUser())
                {
                    HttpContext.Current.Session.Add("user", user);
                }
            }

            public static void RemoveSession()
            {
                if (IsUser())
                {
                    HttpContext.Current.Session.Remove("user");
                }
            }

            public static User getCurrentUser() {
                if (IsUser())
                    return HttpContext.Current.Session["user"] as User;
                else
                    return new User();
            }

            public static bool Login(string username, string password)
            {
                RemoveSession(); //Remove current session

                DataTable user = Optiguy.Database.Query(@"
                    SELECT * FROM Users
                    WHERE Username = '" + username + "' AND Password = '" + password + "'"
                );

                if (user.Rows.Count == 1)
                {
                    string usernameDb = user.Rows[0]["Username"].ToString();
                    string firstnameDb = user.Rows[0]["Firstname"].ToString();
                    string lastnameDb = user.Rows[0]["Lastname"].ToString();
                    string passwordDb = user.Rows[0]["Password"].ToString();
                    int roleDb = Convert.ToInt32(user.Rows[0]["Role"]);

                    // Creating session with userdata from this class
                    CreateSession(new User(usernameDb, firstnameDb, lastnameDb, passwordDb, roleDb));
                    return true;
                }
                else
                {
                    // Logind failed. Creating guest user from this class
                    CreateSession(new User());
                    return false;
                }
            }

            public static void Logout()
            {
                RemoveSession(); //Remove current session
            }
        #endregion
    }
}
