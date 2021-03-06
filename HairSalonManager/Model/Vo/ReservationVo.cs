﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairSalonManager.Model.Vo
{
    class ReservationVo:Notifier
    {
        public uint ResNum { get; set; }


        private uint? _stylistId;

        public uint? StylistId
        {
            get { return _stylistId; }
            set { _stylistId = value;
                OnPropertyChanged("StylistId");
            }
        }

        //public uint? StylistId { get; set; }


        private string _userTel;

        public string UserTel
        {
            get { return _userTel; }
            set { _userTel = value;
                OnPropertyChanged("UserTel");
            }
        }

        //public string UserTel { get; set; }

        public string Note { get; set; }       

        public int Gender { get; set; }

        public DateTime? UserBirthday { get; set; }

        private DateTime _startAt;

        public DateTime StartAt
        {
            get { return _startAt; }
            set
            {
                _startAt = value;
                OnPropertyChanged("StartAt");
            }
        }

        private DateTime _endAt;

        public DateTime EndAt
        {
            get { return _endAt; }
            set { _endAt = value;
                OnPropertyChanged("EndAt");
            }
        }


        public string UserName { get; set; }

        public bool IsPaid { get; set; }
    }
}
