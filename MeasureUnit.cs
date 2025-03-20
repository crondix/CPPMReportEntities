using CPPMReportEntities.Interface;

namespace CPPMReportEntities
{
    public class MeasureUnit: IMeasureUnit
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
