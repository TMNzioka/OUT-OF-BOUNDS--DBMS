﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PTSLibrary
{
    class Team
    {
        private int id;
        private string location;
        private string name;
        private TeamLeader Leader;

        public int TeamId
        {
            get { return id; }
            set { id = value; }
        }

        public TeamLeader Leader
        {
            get { return Leader; }
            set { Leader = value; }
        }

        public string Location
        {
            get { return Location; }
            set { location = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Team(int id, string location, string name TeamLeader leader)
        {
            this.location = location;
            this.name = name;
            this.id = id;
            this.leader = leader;
        }
    }
}