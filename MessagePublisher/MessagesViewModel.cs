using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagePublisher
{
    /// <summary>
    /// Your TODO: please follow insstruction 
    /// </summary>
    public class MessagesViewModel //: IMessagesViewModel
    {
        private readonly IDispatcher _dispatcher;

        public MessagesViewModel(IDispatcher dispatcher)
        {
            _dispatcher = dispatcher;            
        }

        public string UserName{get;set;}

        public UserQueue SelectedUser { get; set; }

        public void PropertyChanged() { 
        
        }

        public IEnumerable<UserQueue> ObservedUsers { 
            get {
                    return ObservedUsers;
                }
            set {
                if (ObservedUsers == null) {
                    ObservedUsers = Globals.GetRandomDataForAllUsers();
                    UserName = value.First().ToString();
                    SelectedUser = value.First();
                } else
                    ObservedUsers = value;
                    //IMessagesViewModel.PropertyChanged();
                    UserName = value.First().ToString();
                    SelectedUser = value.First();
                }

        }

        public string NewMessageText { get{
            return NewMessageText;
        }
            set { 
                NewMessageText = value;
            }
        }

        public MyCommand PublishCommand { get {
            return PublishCommand;
        } }

        public DateTime FromDate { get
        {
            return FromDate;
        }
            set {
                if (FromDate == null)
                {
                   FromDate = DateTime.Today.AddYears(-1);
                }
                else
                {
                    FromDate = value;
                }
            }
        }

        public DateTime ToDate { get
        {
            return ToDate;
        }
            set {
                if (ToDate == null)
                {
                    ToDate = DateTime.Now;
                }
                else
                {
                    ToDate = value;
                }
            }
        }

        public string TextFilter { get {
            return TextFilter;
        }
            set {
                TextFilter = value;
            }
        }

        /*public MyCommand FilterCommand() {
            
        }

        public IEnumerable<Message> FilteredMessages { get {
            return FilteredMessages;
        } }

        public MyCommand SaveCommand { get {
            return SaveCommand;
        } }

        public void FilterContent() {
        
        }*/

    }
}
