// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Position = Protobuf.ProtoMember;
using ProtobufSerializable = Protobuf.ProtoContract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;

namespace Entities.FooBars
{
    /// <summary>Contains the FooBar entity type</summary>
    [ProtoContract]
    [Table("FooBars", Schema = "EntitiesFooBars")]
    public class FooBar : IEntity<int>
    {
        FooBar()
        {
        }

        FooBar(int Baz)
        {
            Baz = baz}

        /// <summary>Contains Baz value</summary>
        [Position(2)]
        int Baz { get; set; }

        /// <summary>FooBar unique identifier (primary key)</summary>
        [Key]
        [Position(1)]
        int FooBarId { get; set; }

        /// <summary>Returns a value that uniquely identifies this entity type. Each entity type in the model has a unique identifier.</summary>
        int GetEntityTypeId() => 5;
    }
}
