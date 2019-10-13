using System;
using System.Collections.Generic;
using System.Text;

namespace Source
{
    public class Team
    {
        private long _id;
        private string _name;
        private DateTime _createDate;
        private string _mainShirtColor;
        private string _secondaryShirtColor;
        private long _captain;

        public Team(long id, string name, DateTime createDate, string mainShirtColor, string secondaryShirtColor)
        {
            _id = id;
            _name = name;
            _createDate = createDate;
            _mainShirtColor = mainShirtColor;
            _secondaryShirtColor = secondaryShirtColor;
        }

        #region [ Variables ] 

        public long Id { get { return _id; } set { _id = value; } }
        
        public string Name { get { return _name; } set { _name = value; } }
        
        public DateTime CreateDate { get { return _createDate; } set { _createDate = value; } }

        public string MainShirtColor { get { return _mainShirtColor; } set { _mainShirtColor = value; } }

        public string SecondaryShirtColor { get { return _secondaryShirtColor; } set { _secondaryShirtColor = value; } }

        public long Captain { get => _captain; set => _captain = value; }

        #endregion

    }
}
