using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebClient.Models
{
    public class Comment
    {
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime PublishedAt { get; set; }

        [Required(ErrorMessage = "Bình luận không được để trống")]
        [StringLength(256, ErrorMessage = "Bình luận phải nhỏ hơn hoặc bằng 256 ký tự")]
        public string Content { get; set; }
        public string TourId { get; set; }
        public string MemberID { get; set; }
        public string ParentId { get; set; }
        public bool Status { get; set; }

        [Required(ErrorMessage = "Tên đầy đủ không được để trống")]
        [StringLength(36, ErrorMessage = "Tên đầy đủ phải nhỏ hơn hoặc bằng 36 ký tự")]
        [RegularExpression("^[a-zA-Z\\s\\.]+$", ErrorMessage = "Tên đầy đủ phải là chuỗi ký tự")]
        public string FullName { get; set; }
        public ICollection<Comment> Childrent { get; set; }
    }
}
