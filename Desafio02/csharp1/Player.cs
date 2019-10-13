using System;
using System.Collections.Generic;
using System.Text;

namespace Source
{
    public class Player
    {
        private long _id;
        private long _teamId;
        private string _name;
        private DateTime _birthDate;
        private int _skillLevel;
        private decimal _salary;

        public Player(long id, long teamId, string name, DateTime birthDate, int skillLevel, decimal salary)
        {
            _id = id;
            _teamId = teamId;
            _name = name;
            _birthDate = birthDate;
            _skillLevel = skillLevel;
            _salary = salary;
        }

        #region [ Variables ]

        public long Id { get => _id; set => _id = value; }
        public long TeamId { get => _teamId; set => _teamId = value; }
        public string Name { get => _name; set => _name = value; }
        public DateTime BirthDate { get => _birthDate; set => _birthDate = value; }
        public int SkillLevel { get => _skillLevel; set => _skillLevel = value; }
        public decimal Salary { get => _salary; set => _salary = value; }

        #endregion
    }
}
