using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLMC_MS.model
{
    class Teams
    {
        public static List<team> GetTeams()
        {
            using (slmc db = new slmc())
            {
                List<team> teams = db.team.Select(i => i).ToList();
                return teams;
            }
        }

        public static team GetTeam(String teamID)
        {
            using (slmc db = new slmc())
            {
                team myTeam = db.team.FirstOrDefault(i => i.teamID.Equals(teamID));
                return myTeam;
            }
        }

        public static team GetTeam(staff staff)
        {
            using (slmc db = new slmc())
            {
                team myTeam = db.team.FirstOrDefault(i => i.teamID.Equals(staff.teamID));
                return myTeam;
            }
        }

        public static team GetTeamByManagerID(String managerID)
        {
            using (slmc db = new slmc())
            {
                team myTeam = db.team.FirstOrDefault(i => i.managerID.Equals(managerID));
                return myTeam;
            }
        }

        public static List<staff> GetTeamMembers(String teamID)
        {
            using (slmc db = new slmc())
            {
                var member = db.staff.Where(i => i.teamID.Equals(teamID)).Select(i => i);
                return member.ToList();
            }
        }

        public static double GetTeamTarget(String teamID, int month, int year)
        {
            using (slmc db = new slmc())
            {
                target target = db.target.FirstOrDefault(i => i.teamID.Equals(teamID) && i.month == month && i.year == year);
                if (target != null)
                    return target.target1;
                else
                    return 0;
            }
        }

        public static void SetTeamTarget(String teamID, int month, int year, double target)
        {
            using (slmc db = new slmc())
            {
                target t = db.target.FirstOrDefault(i => i.teamID.Equals(teamID) && i.month == month && i.year == year);
                if (t != null)
                {
                    t.target1 = target;
                }
                else
                {
                    target newTarget = new target
                    {
                        teamID = teamID,
                        month = month,
                        year = year,
                        target1 = target
                    };
                    db.target.Add(newTarget);
                }
                db.SaveChanges();
            }
        }

        public static double GetTeamRevenue(String teamID, int month, int year)
        {
            double totalNum = 0;
            DateTime min = new DateTime(year, month, 1);
            DateTime max = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            using (slmc db = new slmc())
            {
                IQueryable<orderitem> query = null;

                if (teamID.Equals("MANGE"))
                {
                    query = from list in db.orderitem
                            where list.order.statusID.Equals("copl") && list.order.orderDate >= min && list.order.orderDate <= max
                            select list;
                }
                else
                {
                    query = from list in db.orderitem
                            where list.order.staff.teamID.Equals(teamID) && list.order.statusID.Equals("copl") && list.order.orderDate >= min && list.order.orderDate <= max
                            select list;
                }
                if (query != null)
                    totalNum = query.ToList().Select(i => i.subTotal).Sum();
            }
            return totalNum;
        }

        public static void Add(team team)
        {
            using (slmc db = new slmc())
            {
                db.team.Add(team);
                db.SaveChanges();
            }
        }

        public static void Set(team team, staff manager)
        {
            using (slmc db = new slmc())
            {
                team myTeam = db.team.FirstOrDefault(i => i.teamID.Equals(team.teamID));
                myTeam.managerID = manager.staffID;
                staff myManager = db.staff.FirstOrDefault(i => i.staffID.Equals(manager.staffID));
                myManager.teamID = team.teamID;
                db.SaveChanges();
            }
        }

        public static void Set(team team, String managerID)
        {
            using (slmc db = new slmc())
            {
                team myTeam = db.team.FirstOrDefault(i => i.teamID.Equals(team.teamID));
                myTeam.managerID = managerID;
                db.SaveChanges();
            }
        }

        public static void Set(String teamID, String managerID)
        {
            using (slmc db = new slmc())
            {
                team myTeam = db.team.FirstOrDefault(i => i.teamID.Equals(teamID));
                myTeam.managerID = managerID;
                db.SaveChanges();
            }
        }
    }
}
