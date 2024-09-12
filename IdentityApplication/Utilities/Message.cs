
namespace IdentityApplication.Utilities;

public static class Message
{
    public static string AddMessage(string entityName)
    {
        return entityName + " با موفقیت افزوده شد";
    }

    public static string EditMessage(string entityName)
    {
        return entityName + " با موفقیت ویرایش شد";
    }

    public static string DeleteMessage(string entityName)
    {
        return entityName + " با موفقیت حذف شد";
    }

    public static string NotFoundMessage(string entityName)
    {
        return entityName + " مورد نظر یافت نشد";
    }

    public static string ErrorMessage()
    {
        return "خطا در عملیات";
    }

    public static string SuccessMessage()
    {
        return "عملیات با موفقیت انجام شد";
    }

    public static string UnvalidIdMessage(string entityName)
    {
        return "شناسه وارد شده برای " + entityName + " نامعتبر می باشد";
    }

    public static string IgnoreDeleteMessage(string entityName)
    {
        return entityName + " به علت داشتن زیر مجموعه قابل حذف نمی باشد";
    }

    public static string IsExistMessage(string entityName)
    {
        return entityName + " وارد شده تکراری می باشد";
    }

    public static string SuccessInfoMessage()
    {
        return "اطلاعات با موفقیت ثبت شد";
    }

    public static string NotAllowedMessage()
    {
        return "شما مجاز به انجام این کار نیستید";
    }

    public static string ValidationMessage()
    {
        return "خطای اعتبار سنجی";
    }
}
