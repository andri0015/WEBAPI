
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace webapi.Models;

public class tblArea
{

    public Guid id {get;set;}

    public string name {get;set;}

    public string code {get;set;}

    public bool status {get;set;}
    public Guid costcenterId {get;set;}
    public virtual tblCostCenter costcenter {get;set;}

    public virtual ICollection<tblEmployee> employee {get;set;}

    public DateTime CreationDate {get;set;}
}