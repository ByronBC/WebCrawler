using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScraperClient
{
    public class Item
    {

        #region Propoerties
        private static Item _instance;

        private int _Id;
        private string _Title;
        private int _Points;
        private int _Comments;


        public int Id
        {            
            get { return _Id; }
            set { _Id = value; }
        }

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }
        public int Points
        {
            get { return _Points; }
            set { _Points = value; }
        }
        public int Comments
        {
            get { return _Comments; }
            set { _Comments = value; }
        }

        public int Words
        {
            get { return _Title.Split(' ').Count(); }
        }
        #endregion

        #region Constructor
        public Item(int id, string title, int points, int comments)
        {
            this.Id = id;
            this.Title = title;
            this.Points = points;
            this.Comments = comments;
        }

        protected Item()
        {
            this.Id = -1;
            this.Title = string.Empty;
            this.Points = 0;
            this.Comments = 0;
        }

        public Item Clone()
        {
            return  new Item(this.Id, this.Title, this.Points, this.Comments);
        }
        #endregion

        #region Singleton Initializer
        public static Item Instance()
        {
            if (_instance == null)
            {
                _instance = new Item();
            }
            return _instance;
        }
        #endregion
    }
}