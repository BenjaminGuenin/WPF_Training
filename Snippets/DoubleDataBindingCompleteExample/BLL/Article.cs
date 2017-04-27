using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DoubleDataBindingCompleteExample.BLL
{
    public class Article : INotifyPropertyChanged
    {
        #region Fields

        private string _codeVoyage;
        private string _destination;
        private short _duree;
        private string _description;
        private decimal _prix;
        private bool _promotion;

        #endregion

        #region Properties

        public string CodeVoyage
        {
            get { return _codeVoyage; }
            set
            {
                if (value == _codeVoyage) return;
                _codeVoyage = value;
                OnPropertyChanged();
            }
        }

        public string Destination
        {
            get { return _destination; }
            set
            {
                if (value == _destination) return;
                _destination = value;
                OnPropertyChanged();
            }
        }

        public short Duree
        {
            get { return _duree; }
            set
            {
                if (value == _duree) return;
                _duree = value;
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                if (value == _description) return;
                _description = value;
                OnPropertyChanged();
            }
        }

        public decimal Prix
        {
            get { return _prix; }
            set
            {
                if (value == _prix) return;
                _prix = value;
                OnPropertyChanged();
            }
        }

        public bool Promotion
        {
            get { return _promotion; }
            set
            {
                if (value == _promotion) return;
                _promotion = value;
                OnPropertyChanged();
            }
        }
        
        #endregion

        public override string ToString()
        {
            return CodeVoyage + " " + Destination;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
