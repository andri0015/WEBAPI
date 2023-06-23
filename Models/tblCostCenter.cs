using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models;

public class tblCostCenter
{
    public Guid id {get;set;}

    public string name {get;set;}


    public string code {get;set;}

    public Boolean status {get;set;}
     public virtual ICollection<tblArea> area {get;set;}
    public DateTime CreationDate {get;set;}
}