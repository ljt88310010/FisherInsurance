using System;
namespace FisherInsurance.Models
{
 public class claim
 {
 public int Id { get; set; }
 public string PolicyType { get; set; }
 public DateTime LossDate { get; set; }
 public decimal LossAmount { get; set; }
 }
}