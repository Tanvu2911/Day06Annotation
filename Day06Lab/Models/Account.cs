using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Day06Lab.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        [
            Display(Name ="Họ và tên"),
            Required(ErrorMessage ="Họ tên không được để trống"),
           StringLength(20,MinimumLength =6 , ErrorMessage =("họ tên từ 6 đến 20 ký tự"))
        ]
        public string FullName { get; set; }
        [  
            Display(Name = "Email"),
            Required(ErrorMessage ="Email không được để trống"),
            EmailAddress(ErrorMessage ="Email không đúng định dạng"),

         ]
        public string Email {  get; set; }
        [
            Display(Name ="Số điẹn thoại"),
            Required(ErrorMessage = "Số diện thoại không được để trống"),
            Phone(ErrorMessage ="Số điện thoại không hợp lệ"),
            //RegularExpression(@"^(0[0-9]{9})$", ErrorMessage ="Số điện thoại phải đủ 10 số và bắt đầu bằng số không")
            Remote(action: "VerifyPhone", controller:"Account")
        ]

        public string Phone {  get; set; }

        [
            Required(ErrorMessage ="Địa chỉ không được để trống"),
            Display(Name = "Địa chỉ thường chú"),
            StringLength(35, ErrorMessage ="Không được vượt quá 35 ký tự")
            ]
        public string Address {  get; set; }


        [Display(Name = "Ảnh đại diện")]
        public string Avatar { get; set; }
        [
            Display(Name ="Ngày sinh"),
            Required(ErrorMessage ="Ngày sinh không được để trống"),
            DataType(DataType.Date)
            ]
        public DateTime Birthday { get; set; }


        [Display(Name = "Giới tính")]
        public string Gender { get; set; }
        [Display(Name = "Mật khẩu"),
            DataType(DataType.Password),
            ]

        public string Password {  get; set; }
        [Display(Name = "Facebook"),
            Required(ErrorMessage ="Link Facebook không được để trống"),
            Url(ErrorMessage ="URL phải đúng định dạng")]

        public string Facebook { get; set; }

    }
}
