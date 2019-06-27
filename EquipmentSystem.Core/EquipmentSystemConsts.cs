namespace EquipmentSystem
{
    public class EquipmentSystemConsts
    {
        public const string LocalizationSourceName = "EquipmentSystem";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default page size for paged requests.
        /// </summary>
        public const int DefaultPageSize = 10;

        /// <summary>
        /// Maximum allowed page size for paged requests.
        /// </summary>
        public const int MaxPageSize = 1000;
        /// <summary>
        /// 邮件地址最大长度
        /// </summary>
        public const int MaxEmailAddressLength = 255;
    }
}