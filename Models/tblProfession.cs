using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace webapi.Models;

public class tblProfession
{    
    public Guid id {get;set;}
    
    public string name {get;set;}

    public string code {get;set;}

    public Boolean status {get;set;}
    [JsonIgnore]
    public virtual ICollection<tblEmployee> employee {get;set;}

    public DateTime CreationDate {get;set;}
}