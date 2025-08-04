using AntdUI;

namespace AntdUIDemo.Models
{
    public class User : NotifyProperty
    {
        private bool selected = false;
        private string name;
        private int age = 0;
        private string address;
        private bool enabled = false;
        private CellImage[] cellImages;
        private CellTag[] cellTags;
        private CellBadge cellBadge;
        private CellText cellText;
        private CellLink[] cellLinks;
        private CellProgress cellProgress;
        private CellDivider cellDivider;
        //用于设置树形表格，加入自身数组
        private User[] users;

        public bool Selected
        {
            get { return selected; }
            set
            {
                if (selected == value) return;
                selected = value;
                OnPropertyChanged(nameof(Selected));
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (name == value) return;
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (age == value) return;
                age = value;
                OnPropertyChanged(nameof(Age));
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                if (address == value) return;
                address = value;
                OnPropertyChanged(nameof(Address));
            }
        }

        public bool Enabled
        {
            get { return enabled; }
            set
            {
                if (enabled == value) return;
                enabled = value;
                OnPropertyChanged(nameof(Enabled));
            }
        }

        public CellImage[] CellImages
        {
            get { return cellImages; }
            set
            {
                if (cellImages == value) return;
                cellImages = value;
                OnPropertyChanged(nameof(CellImages));
            }
        }

        public CellTag[] CellTags
        {
            get { return cellTags; }
            set
            {
                if (cellTags == value) return;
                cellTags = value;
                OnPropertyChanged(nameof(CellTags));
            }
        }

        public CellBadge CellBadge
        {
            get { return cellBadge; }
            set
            {
                if (cellBadge == value) return;
                cellBadge = value;
                OnPropertyChanged(nameof(CellBadge));
            }
        }

        public CellText CellText
        {
            get { return cellText; }
            set
            {
                if (cellText == value) return;
                cellText = value;
                OnPropertyChanged(nameof(CellText));
            }
        }

        public CellLink[] CellLinks
        {
            get { return cellLinks; }
            set
            {
                if (cellLinks == value) return;
                cellLinks = value;
                OnPropertyChanged(nameof(CellLinks));
            }
        }

        public CellProgress CellProgress
        {
            get { return cellProgress; }
            set
            {
                if (cellProgress == value) return;
                cellProgress = value;
                OnPropertyChanged(nameof(CellProgress));
            }
        }

        public CellDivider CellDivider
        {
            get { return cellDivider; }
            set
            {
                if (cellDivider == value) return;
                cellDivider = value;
                OnPropertyChanged(nameof(CellDivider));
            }
        }

        public User[] Users
        {
            get { return users; }
            set
            {
                if (users == value) return;
                users = value;
                OnPropertyChanged(nameof(Users));
            }

        }
    }
}
