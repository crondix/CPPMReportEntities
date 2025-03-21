using CPPMReportEntities;

using DevExpress.Xpo;

public class ПростойОборудования : XPObject
{
    public ПростойОборудования(Session сеанс) : base(сеанс) { }

    private DateTime времяНачала;
    private DateTime времяОкончания;
    private ПричинаПростояОборудования? причинаПростоя;
    private string? комментарий;
    private Guid oid;

    [Key]
    public Guid OID
    {
        get => oid;
        set => SetPropertyValue(nameof(OID), ref oid, value);
    }
    public DateTime ВремяНачала
    {
        get => времяНачала;
        set => SetPropertyValue(nameof(ВремяНачала), ref времяНачала, value);
    }

    public DateTime ВремяОкончания
    {
        get => времяОкончания;
        set => SetPropertyValue(nameof(ВремяОкончания), ref времяОкончания, value);
    }

    public ПричинаПростояОборудования? ПричинаПростоя
    {
        get => причинаПростоя;
        set => SetPropertyValue(nameof(ПричинаПростоя), ref причинаПростоя, value);
    }

    [Size(1024)]
    public string? Комментарий
    {
        get => комментарий;
        set => SetPropertyValue(nameof(Комментарий), ref комментарий, value);
    }
}
