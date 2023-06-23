using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models;

public class tblEmployee
{
    public Guid id {get;set;}

    public string identification {get;set;}

    public string name {get;set;}

    public int age {get;set;}


    public string phone {get;set;}


    public string address {get;set;}


    public string user {get;set;}
    public Guid areaId {get;set;}
    public virtual tblArea area {get;set;}
    public Guid professionId {get;set;}
    public virtual tblProfession profession {get;set;}

    public DateTime CreationDate {get;set;}
}