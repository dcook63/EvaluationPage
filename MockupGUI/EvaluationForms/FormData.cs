using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MockupGUI
{
    public class FormData
    {
        public int _Contribution;
        public int Contribution
        {
            get
            {
                return _Contribution;
            }
            set
            {
                _Contribution = value;
            }
        }
        public string _Contribution_Comment;
        public string Contribution_Comment
        {
            get
            {
                return _Contribution_Comment;
            }
            set
            {
                _Contribution_Comment = value;
            }
        }
        public int _Communication;
        public int Communication
        {
            get
            {
                return _Communication;
            }
            set
            {
                _Communication = value;
            }
        }
        public string _Communication_Comment;
        public string Communication_Comment
        {
            get
            {
                return _Communication_Comment;
            }
            set
            {
                _Communication_Comment = value;
            }
        }
        public int _Teamwork;
        public int Teamwork
        {
            get
            {
                return _Teamwork;
            }
            set
            {
                _Teamwork = value;
            }
        }
        public string _Teamwork_Comment;
        public string Teamwork_Comment
        {
            get
            {
                return _Teamwork_Comment;
            }
            set
            {
                _Teamwork_Comment = value;
            }
        }
        public int _General;
        public int General
        {
            get
            {
                return _General;
            }
            set
            {
                _General = value;
            }
        }
        public string _General_Comment;
        public string General_Comment
        {
            get
            {
                return _General_Comment;
            }
            set
            {
                _General_Comment = value;
            }
        }
        public int _Overall;
        public int Overall
        {
            get
            {
                return _Overall;
            }
            set
            {
                _Overall = value;
            }
        }
        public string _Overall_Comment;
        public string Overall_Comment
        {
            get
            {
                return _Overall_Comment;
            }
            set
            {
                _Overall_Comment = value;
            }
        }
        public void FillData(int cont, string cont_com, int comm, string comm_com, int team, string team_com, int gen, string gen_com, int ovr, string ovr_com)
        {
            Contribution = cont;
            Contribution_Comment = cont_com;
            Communication = comm;
            Communication_Comment = comm_com;
            Teamwork = team;
            Teamwork_Comment = team_com;
            General = gen;
            General_Comment = gen_com;
            Overall = ovr;
            Overall_Comment = ovr_com;
        }
    }
}