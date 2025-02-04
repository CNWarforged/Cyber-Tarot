using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Cyber_Tarot
{
    internal class dbAccess
    {

        public static TarotCard ReadDB(int dbkey)
        {
            var tarotCard = new TarotCard();

            using (OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\shini\\Documents\\CS 361\\TarotCards.accdb"))
            {
                con.Open();
                var query = "SELECT DBKey, Name, ArcanaType, Upright, ShortDescription from TarotCards WHERE DBKey= ?Key?";
                tarotCard = con.QuerySingle<TarotCard>(query, new { Key = dbkey });
                con.Close();
            }

            return tarotCard;
        }
    }
}
