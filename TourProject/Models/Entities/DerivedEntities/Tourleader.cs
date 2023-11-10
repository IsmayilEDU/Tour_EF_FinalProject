using Models.AssistantModels.Interfaces;
using Models.Entities.AbstractEntities;

namespace Models.Entities.DerivedEntities
{
    public class Tourleader : Human, IId
    {
        #region Fields

        //  Id
        public int Id { get; init; }

        #endregion

        #region Navigation properties
        public virtual ICollection<Tour> Tours { get; set; }
        #endregion
    }
}
