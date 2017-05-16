﻿using App.Gwin.Attributes;
using App.Gwin.Entities;
using Entities.InstitutionManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.StaffManagement
{
    [GwinEntity(Localizable = true, isMaleName = true, DisplayMember = "Name")]
    [Menu(Group = "HRManagement")]
    public  class Affectation:BaseEntity
    {
        [EntryForm(Ordre = 1,WidthControl =350)]
        [DataGrid(WidthColonne = 100)]
        public DateTime DateAffectation { get; set; }

        [EntryForm(Ordre = 1,WidthControl =350)]
        [DataGrid(WidthColonne = 100)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        public Institution Institution { get; set; }

        [EntryForm(Ordre = 1, WidthControl = 350)]
        [DisplayProperty(DisplayMember = "RegistrationNumber")]
        [DataGrid(WidthColonne = 100)]
        [Relationship(Relation = RelationshipAttribute.Relations.ManyToOne)]
        [Filter(isValeurFiltreVide =true)]
        public Staff Staff { get; set; }

        [NotMapped]
        public string Name
        {
            get
            {
                if (Institution != null && DateAffectation != null)
                    return Institution + ":" + DateAffectation.ToShortDateString();
                else
                {
                    return "";
                }

            }
        }
    }
}
