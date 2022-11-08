
namespace CA_Formacion.Presenters.Abstractions
{
    public interface IPresenter<TFormat>
    {
        public TFormat Content { get;  }
    }
}
