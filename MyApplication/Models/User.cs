namespace Models
{
	public class User : BaseEntity
	{
		public User() : base()
		{
		}

		// **********
        //برای ساخت فرم لاگین ، رجیستر دارد و ... لزم است
        // مثلا اگر این گزینه false بود... اجازه لاگین ندارد
		public bool IsActive { get; set; }
		// **********

		// **********
        //اضافه کردن برای اختصاص یک منوی اضافه برای ادمین، مثل منوی کاربران و ...
		public bool IsAdmin { get; set; }
        // **********

        // **********
        //Attribiuts
        // این اتریبیوتها برای نازک کاری انتیتی فریم ورک هستند
        //هم در اپلیکیشن موثر است و هم در دیتابیس
        //با این دستور نباید مقدار آن nullstring  شود
        //هم در اپلیکیشن و هم در دیتابیس کاربرد دارد
        [System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]
        //برای تعیین حداقل و حداکثر طول فیلد
        //هم در اپلیکیشن و هم در دیتابیس کاربرد دارد
        [System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20, MinimumLength = 6)]
        //این فقط در دیتابیس موثر است
		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]
		public string Username { get; set; }
        // **********

        // **********
        //هم در اپلیکیشن و هم در دیتابیس کاربرد دارد 
        [System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 40, MinimumLength = 8)]
		public string Password { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50)]

        //سرعت مرتب سازی و جستجو را بالا می برد
        [System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = false)]
		public string FullName { get; set; }
		// **********

		// **********
		public string Description { get; set; }
        // **********

        //System.ComponentModel.DataAnnotations.
    }
}
