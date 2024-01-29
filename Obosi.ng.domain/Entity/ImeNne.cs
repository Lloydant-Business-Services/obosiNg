namespace Obosi.ng.Domain.Entity
{
    public class  ImeNne : Base
    {
        public int UnitId { get; set; }
        public virtual Unit Unit { get; set; }
    }
}
