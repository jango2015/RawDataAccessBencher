﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.3.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace EFCore20.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'ContactCreditCard'.</summary>
	public partial class ContactCreditCard : CommonEntityBase
	{
		#region Class Extensibility Methods
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();
		#endregion

		/// <summary>Initializes a new instance of the <see cref="ContactCreditCard"/> class.</summary>
		public ContactCreditCard() : base()
		{
			OnCreated();
		}

		/// <summary>Gets or sets the ContactId field. </summary>
		public System.Int32 ContactId { get; set;}
		/// <summary>Gets or sets the CreditCardId field. </summary>
		public System.Int32 CreditCardId { get; set;}
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'ContactCreditCard.CreditCard - CreditCard.ContactCreditCards (m:1)'</summary>
		public CreditCard CreditCard { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'ContactCreditCard.Person - Person.Person.ContactCreditCards (m:1)'</summary>
		public Person Person { get; set;}
	}
}
