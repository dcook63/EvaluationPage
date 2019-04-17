using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MockupGUI
{
    public class FormData
    {
        //Student Info
        public string _Student;
        public string Student
        {
            get
            {
                return _Student;
            }
            set
            {
                _Student = value;
            }
        }
        public int _Student_ID;
        public int Student_ID
        {
            get
            {
                return _Student_ID;
            }
            set
            {
                _Student_ID = value;
            }
        }


        //Peer Review
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
        public int _Overall_Peer;
        public int Overall_Peer
        {
            get
            {
                return _Overall_Peer;
            }
            set
            {
                _Overall_Peer = value;
            }
        }
        public string _Overall_Peer_Comment;
        public string Overall_Peer_Comment
        {
            get
            {
                return _Overall_Peer_Comment;
            }
            set
            {
                _Overall_Peer_Comment = value;
            }
        }

        //Presentation_Eval
        public int _Poster;
        public int Poster
        {
            get
            {
                return _Poster;
            }
            set
            {
               _Poster = value;
            }
        }
        public string _Poster_Comment;
        public string Poster_Comment
        {
            get
            {
                return _Poster_Comment;
            }
            set
            {
                _Poster_Comment = value;
            }
        }
        public int _Teamtalk;
        public int Teamtalk
        {
            get
            {
                return _Teamtalk;
            }
            set
            {
                _Teamtalk = value;
            }
        }
        public string _Teamtalk_Comment;
        public string Teamtalk_Comment
        {
            get
            {
                return _Teamtalk_Comment;
            }
            set
            {
                _Teamtalk_Comment = value;
            }
        }
        public int _Slides;
        public int Slides
        {
            get
            {
                return _Slides;
            }
            set
            {
                _Slides = value;
            }
        }
        public string _Slides_Comment;
        public string Slides_Comment
        {
            get
            {
                return _Slides_Comment;
            }
            set
            {
                _Slides_Comment = value;
            }
        }
        public int _Presentation;
        public int Presentation
        {
            get
            {
                return _Presentation;
            }
            set
            {
                _Presentation = value;
            }
        }
        public string _Presentation_Comment;
        public string Presentation_Comment
        {
            get
            {
                return _Presentation_Comment;
            }
            set
            {
                _Presentation_Comment = value;
            }
        }
        public int _Deliverables;
        public int Deliverables
        {
            get
            {
                return _Deliverables;
            }
            set
            {
                _Deliverables = value;
            }
        }
        public string _Deliverables_Comment;
        public string Deliverables_Comment
        {
            get
            {
                return _Deliverables_Comment;
            }
            set
            {
                _Deliverables_Comment = value;
            }
        }
        public int _Softskills;
        public int Softskills
        {
            get
            {
                return _Softskills;
            }
            set
            {
                _Softskills = value;
            }
        }
        public string _Softskills_Comment;
        public string Softskills_Comment
        {
            get
            {
                return _Softskills_Comment;
            }
            set
            {
                _Softskills_Comment = value;
            }
        }
        public int _Overall_Pres;
        public int Overall_Pres
        {
            get
            {
                return _Overall_Pres;
            }
            set
            {
                _Overall_Pres = value;
            }
        }


        public void FillPeerData(int cont, string cont_com, int comm, string comm_com, int team, string team_com, int gen, string gen_com, int ovr, string ovr_com)
        {
            Contribution = cont;
            Contribution_Comment = cont_com;
            Communication = comm;
            Communication_Comment = comm_com;
            Teamwork = team;
            Teamwork_Comment = team_com;
            General = gen;
            General_Comment = gen_com;
            Overall_Peer = ovr;
            Overall_Peer_Comment = ovr_com;
        }
    }
}