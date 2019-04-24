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
        public string _Role;
        public string Role
        {
            get
            {
                return _Role;
            }
            set
            {
                _Role = value;
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
        public string _Project_ID;
        public string Project_ID
        {
            get
            {
                return _Project_ID;
            }
            set
            {
                _Project_ID = value;
            }
        }

        public string _Sponsor_ID;
        public string Sponsor_ID
        {
            get
            {
                return _Sponsor_ID;
            }
            set
            {
                _Sponsor_ID = value;
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
        public string _Comment_on_Excellence;
        public string Comment_on_Excellence
        {
            get
            {
                return _Comment_on_Excellence;
            }
            set
            {
                _Comment_on_Excellence = value;
            }
        }
        public string _Comment_on_Weakness;
        public string Comment_on_Weakness
        {
            get
            {
                return _Comment_on_Weakness;
            }
            set
            {
                _Comment_on_Weakness = value;
            }
        }
        public string _Comment_on_website;
        public string Comment_on_website
        {
            get
            {
                return _Comment_on_website;
            }
            set
            {
                _Comment_on_website = value;
            }
        }
        public string _Comment_on_Improvements;
        public string Comment_on_Improvements
        {
            get
            {
                return _Comment_on_Improvements;
            }
            set
            {
                _Comment_on_Improvements = value;
            }
        }

        //Sponsor_Eval
        public int _Clarity;
        public int Clarity
        {
            get
            {
                return _Clarity;
            }
            set
            {
                _Clarity = value;
            }
        }

        public string _Clarity_Comment;
        public string Clarity_Comment
        {
            get
            {
                return _Clarity_Comment;
            }
            set
            {
                _Clarity_Comment = value;
            }
        }

        public int _Quality;
        public int Quality
        {
            get
            {
                return _Quality;
            }
            set
            {
                _Quality = value;
            }
        }

        public string _Quality_Comment;
        public string Quality_Comment
        {
            get
            {
                return _Quality_Comment;
            }
            set
            {
                _Quality_Comment = value;
            }
        }

        public int _Sponsor_Communication;
        public int Sponsor_Communication
        {
            get
            {
                return _Sponsor_Communication;
            }
            set
            {
                _Sponsor_Communication = value;
            }
        }

        public string _Sponsor_Communication_Comment;
        public string Sponsor_Communication_Comment
        {
            get
            {
                return _Sponsor_Communication_Comment;
            }
            set
            {
                _Sponsor_Communication_Comment = value;
            }
        }

        public int _Commitment;
        public int Commitment
        {
            get
            {
                return _Commitment;
            }
            set
            {
                _Commitment = value;
            }
        }

        public string _Commitment_Comment;
        public string Commitment_Comment
        {
            get
            {
                return _Commitment_Comment;
            }
            set
            {
                _Commitment_Comment = value;
            }
        }

        public int _Management;
        public int Management
        {
            get
            {
                return _Management;
            }
            set
            {
                _Management = value;
            }
        }

        public string _Management_Comment;
        public string Management_Comment
        {
            get
            {
                return _Management_Comment;
            }
            set
            {
                _Management_Comment = value;
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

        public string _Comment_on_Deliverables;
        public string Comment_on_Deliverables
        {
            get
            {
                return _Comment_on_Deliverables;
            }
            set
            {
                _Comment_on_Deliverables = value;
            }
        }

        public string _Comment_on_Team;
        public string Comment_on_Team
        {
            get
            {
                return _Comment_on_Team;
            }
            set
            {
                _Comment_on_Team = value;
            }
        }

        public string _Feedback_on_Improvements;
        public string Feedback_on_Improvements
        {
            get
            {
                return _Feedback_on_Improvements;
            }
            set
            {
                _Feedback_on_Improvements = value;
            }
        }

        public string _Value_to_Organization;
        public string Value_to_Organization
        {
            get
            {
                return _Value_to_Organization;
            }
            set
            {
                _Value_to_Organization = value;
            }
        }

        public string _Comment_on_Capstone;
        public string Comment_on_Capstone
        {
            get
            {
                return _Comment_on_Capstone;
            }
            set
            {
                _Comment_on_Capstone = value;
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

        public void FillSponsorData(int clar, string clar_com, int qual, string qual_com, int comm, string comm_com, int commit, string commit_com, int mana, string mana_com, int ovr, string ovr_com, string COD, string COT, string FOI, string VTO, string COC)
        {
            Clarity = clar;
            Clarity_Comment = clar_com;
            Quality = qual;
            Quality_Comment = qual_com;
            Communication = comm;
            Communication_Comment = comm_com;
            Commitment = commit;
            Commitment_Comment = commit_com;
            Management = mana;
            Management_Comment = mana_com;
            Overall = ovr;
            Overall_Comment = ovr_com;
            Comment_on_Deliverables = COD;
            Comment_on_Team = COT;
            Feedback_on_Improvements = FOI;
            Value_to_Organization = VTO;
            Comment_on_Capstone = COC;
        }

        public void FillPresentationData(int poster, string poster_com, int ttalk, string ttalk_com, int slide, string slide_com, int pres, string pres_com, int deliv, string deliv_com, int sskill, string sskill_com, int ovr, string COE, string COW, string COWeb, string COI)
        {
            Poster = poster;
            Poster_Comment = poster_com;
            Teamtalk = ttalk;
            Teamtalk_Comment = ttalk_com;
            Slides = slide;
            Slides_Comment = slide_com;
            Presentation = pres;
            Presentation_Comment = pres_com;
            Deliverables = deliv;
            Deliverables_Comment = deliv_com;
            Softskills = sskill;
            Softskills_Comment = sskill_com;
            Overall = ovr;
            Comment_on_Excellence = COE;
            Comment_on_Weakness = COW;
            Comment_on_website = COWeb;
            Comment_on_Improvements = COI;
        }
    }
}