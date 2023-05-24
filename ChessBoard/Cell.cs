namespace ChessBoard
{
    public class Cell : NotifyPropertyChanged
    {
        private State _state;
        private bool _active;

        public State State
        {
            get => _state;
            set
            {
                _state = value;
                OnPropertyChanged(); // сообщить интерфейсу, что значение поменялось, чтобы интефейс перерисовался в этом месте
            }
        }
        public bool Active // это будет показывать, что ячейка выделена пользователем
        {
            get => _active;
            set
            {
                _active = value;
                OnPropertyChanged();
            }
        }
    }
}