using JordanRigs.Enums;

namespace JordanRigs.Data.Entities
{
    public class Crew
    {
        public int Id { get; set; }
        public Shift Shift { get; set; }

        public int FieldId { get; set; }
    }
}
