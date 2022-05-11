using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLMC_MS.model
{
    class BroadcastMsgs
    {
        public static broadcastmsg GetBroadcastmsg(int msgID)
        {
            using (slmc db = new slmc())
            {
                broadcastmsg msg = db.broadcastmsg.FirstOrDefault(i => i.msgID == msgID);
                return msg;
            }
        }

        public static List<broadcastmsg> GetBroadcastMsgsBySenderID(String senderID)
        {
            using (slmc db = new slmc())
            {
                var msgs = db.broadcastmsg.Where(i => i.senderID.Equals(senderID));
                return msgs.ToList();
            }
        }

        public static List<broadcastmsg> GetBroadcastMsgsByReceiverID(String receiverID)
        {
            using (slmc db = new slmc())
            {
                var msgs = from list in db.msgreceiver
                           where list.receiverID.Equals(receiverID)
                           select list.broadcastmsg;
                return msgs.ToList();
            }
        }

        public static List<broadcastmsg> GetUnreadedMsgs(String receiverID)
        {
            using (slmc db = new slmc())
            {
                var msgs = from list in db.msgreceiver
                           where list.receiverID.Equals(receiverID) && list.readed.Equals("N") && list.broadcastmsg.deliveryDate <= DateTime.Today
                           select list.broadcastmsg;
                return msgs.ToList();
            }
        }

        public static List<broadcastmsg> GetReadedMsgs(String receiverID)
        {
            using (slmc db = new slmc())
            {
                var msgs = from list in db.msgreceiver
                           where list.receiverID.Equals(receiverID) && list.readed.Equals("Y") && list.broadcastmsg.deliveryDate <= DateTime.Today
                           select list.broadcastmsg;
                return msgs.ToList();
            }
        }

        public static void SetReadedMsg(int msgID, String receiverID)
        {
            using (slmc db = new slmc())
            {
                var msgs = db.msgreceiver.FirstOrDefault(i => i.msgID == msgID && i.receiverID.Equals(receiverID));
                msgs.readed = "Y";
                db.SaveChanges();
            }
        }

        public static List<team> GetReceiverTeams(int msgID)
        {
            using (slmc db = new slmc())
            {
                var receivers = from list in db.msgreceiver
                                where list.msgID == msgID
                                select list.staff;
                var t = from list in receivers
                         group list by list.team into g
                         select new { team = g.Key, teamCount = g.Count() };
                return t.Select(i => i.team).ToList();
            }
        }

        

        public static void DeleteMessage(int msgID)
        {
            using (slmc db = new slmc())
            {
                broadcastmsg msg = db.broadcastmsg.FirstOrDefault(i => i.msgID == msgID);
                msg.msgreceiver.Clear();
                db.broadcastmsg.Remove(msg);

                db.SaveChanges();
            }
        }
    }
}
