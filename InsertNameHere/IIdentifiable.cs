
namespace InsertNameHere.Models
{
    public interface IIdentifiable
    {
        public string Id;

        public virtual void Adjust() { }
    }
}