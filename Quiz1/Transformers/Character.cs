public class Character1
{
    private readonly FormType[] compatibleFormTypes =
    {
        FormType.Truck,
        FormType.Humanoid
    };

    private FormType formType = FormType.Humanoid;

    public void SetForm(FormType form)
    {
        if (compatibleFormTypes.Contains(form)) formType = form;
    }
}

public enum FormType
{
    Humanoid,
    Truck
}
