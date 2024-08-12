using Core.DataManager.Enums;

namespace Core.DataManager.Models
{
    public class Position
    {
        public int PositionId { get; set; }
        public string PositionName { get; set; } = string.Empty;
        public string PositionDescription { get; set; } = string.Empty;
        public PositionType PositionType { get; set; }
        public int Salary { get; set; }
        public bool IsActive { get; set; }
    }
}
