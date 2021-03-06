// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using DevOps.Code.Entities.Interfaces.Entity;
using Position = ProtoBuf.ProtoMemberAttribute;
using ProtoBufSerializable = ProtoBuf.ProtoContractAttribute;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;

namespace Entities.FooBars
{
    /// <summary>Contains the FooBar entity type</summary>
    [ProtoBufSerializable]
    [Table("FooBars", Schema = "Entities")]
    public class FooBar : IEntity<int>
    {
        public FooBar()
        {
        }

        public FooBar(int baz)
        {
            Baz = baz;
        }

        /// <summary>Contains Baz value</summary>
        [Position(2)]
        public int Baz { get; set; }

        /// <summary>FooBar unique identifier (primary key)</summary>
        [Key]
        [Position(1)]
        public int FooBarId { get; set; }

        /// <summary>Returns a value that uniquely identifies this entity type. Each entity type in the model has a unique identifier</summary>
        public int GetEntityType() => 5;

        /// <summary>Returns the entity's unique identifier</summary>
        public int GetKey() => FooBarId;
    }
}
