using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Xml;
namespace Lab1App
{
	namespace ORMModel1
	{
		#region Patient
		[DataObject()]
		[System.CodeDom.Compiler.GeneratedCode("OIALtoPLiX", "1.0")]
		[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet=System.Runtime.InteropServices.CharSet.Auto)]
		public abstract partial class Patient : INotifyPropertyChanged, IHasORMModel1Context
		{
			protected Patient()
			{
			}
			#region Patient INotifyPropertyChanged Implementation
			private PropertyChangedEventHandler _propertyChangedEventHandler;
			[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
			event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
			{
				add
				{
					if ((object)value != null)
					{
						PropertyChangedEventHandler currentHandler;
						while ((object)System.Threading.Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this._propertyChangedEventHandler, (PropertyChangedEventHandler)System.Delegate.Combine(currentHandler = this._propertyChangedEventHandler, value), currentHandler) != (object)currentHandler)
						{
						}
					}
				}
				remove
				{
					if ((object)value != null)
					{
						PropertyChangedEventHandler currentHandler;
						while ((object)System.Threading.Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this._propertyChangedEventHandler, (PropertyChangedEventHandler)System.Delegate.Remove(currentHandler = this._propertyChangedEventHandler, value), currentHandler) != (object)currentHandler)
						{
						}
					}
				}
			}
			private void OnPropertyChanged(string propertyName)
			{
				PropertyChangedEventHandler eventHandler;
				if ((object)(eventHandler = this._propertyChangedEventHandler) != null)
				{
					EventHandlerUtility.InvokeEventHandlerAsync(eventHandler, this, new PropertyChangedEventArgs(propertyName));
				}
			}
			#endregion // Patient INotifyPropertyChanged Implementation
			#region Patient Property Change Events
			private System.Delegate[] _events;
			private System.Delegate[] Events
			{
				get
				{
					System.Delegate[] localEvents;
					return (localEvents = this._events) ?? System.Threading.Interlocked.CompareExchange<System.Delegate[]>(ref this._events, localEvents = new System.Delegate[6], null) ?? localEvents;
				}
			}
			private static void InterlockedDelegateCombine(ref System.Delegate location, System.Delegate value)
			{
				System.Delegate currentHandler;
				while ((object)System.Threading.Interlocked.CompareExchange<System.Delegate>(ref location, System.Delegate.Combine(currentHandler = location, value), currentHandler) != (object)currentHandler)
				{
				}
			}
			private static void InterlockedDelegateRemove(ref System.Delegate location, System.Delegate value)
			{
				System.Delegate currentHandler;
				while ((object)System.Threading.Interlocked.CompareExchange<System.Delegate>(ref location, System.Delegate.Remove(currentHandler = location, value), currentHandler) != (object)currentHandler)
				{
				}
			}
			public event EventHandler<PropertyChangingEventArgs<Patient, int>> PatientNrChanging
			{
				add
				{
					if ((object)value != null)
					{
						Patient.InterlockedDelegateCombine(ref this.Events[0], value);
					}
				}
				remove
				{
					System.Delegate[] events;
					if ((object)value != null && (object)(events = this._events) != null)
					{
						Patient.InterlockedDelegateRemove(ref events[0], value);
					}
				}
			}
			protected bool OnPatientNrChanging(int newValue)
			{
				System.Delegate[] events;
				EventHandler<PropertyChangingEventArgs<Patient, int>> eventHandler;
				if ((object)(events = this._events) != null && (object)(eventHandler = (EventHandler<PropertyChangingEventArgs<Patient, int>>)events[0]) != null)
				{
					return EventHandlerUtility.InvokeCancelableEventHandler<PropertyChangingEventArgs<Patient, int>>(eventHandler, this, new PropertyChangingEventArgs<Patient, int>(this, "PatientNr", this.PatientNr, newValue));
				}
				return true;
			}
			public event EventHandler<PropertyChangedEventArgs<Patient, int>> PatientNrChanged
			{
				add
				{
					if ((object)value != null)
					{
						Patient.InterlockedDelegateCombine(ref this.Events[1], value);
					}
				}
				remove
				{
					System.Delegate[] events;
					if ((object)value != null && (object)(events = this._events) != null)
					{
						Patient.InterlockedDelegateRemove(ref events[1], value);
					}
				}
			}
			protected void OnPatientNrChanged(int oldValue)
			{
				System.Delegate[] events;
				EventHandler<PropertyChangedEventArgs<Patient, int>> eventHandler;
				if ((object)(events = this._events) != null && (object)(eventHandler = (EventHandler<PropertyChangedEventArgs<Patient, int>>)events[1]) != null)
				{
					EventHandlerUtility.InvokeEventHandlerAsync<PropertyChangedEventArgs<Patient, int>>(eventHandler, this, new PropertyChangedEventArgs<Patient, int>(this, "PatientNr", oldValue, this.PatientNr), this._propertyChangedEventHandler);
				}
				else
				{
					this.OnPropertyChanged("PatientNr");
				}
			}
			public event EventHandler<PropertyChangingEventArgs<Patient, string>> PatientNameChanging
			{
				add
				{
					if ((object)value != null)
					{
						Patient.InterlockedDelegateCombine(ref this.Events[2], value);
					}
				}
				remove
				{
					System.Delegate[] events;
					if ((object)value != null && (object)(events = this._events) != null)
					{
						Patient.InterlockedDelegateRemove(ref events[2], value);
					}
				}
			}
			protected bool OnPatientNameChanging(string newValue)
			{
				System.Delegate[] events;
				EventHandler<PropertyChangingEventArgs<Patient, string>> eventHandler;
				if ((object)(events = this._events) != null && (object)(eventHandler = (EventHandler<PropertyChangingEventArgs<Patient, string>>)events[2]) != null)
				{
					return EventHandlerUtility.InvokeCancelableEventHandler<PropertyChangingEventArgs<Patient, string>>(eventHandler, this, new PropertyChangingEventArgs<Patient, string>(this, "PatientName", this.PatientName, newValue));
				}
				return true;
			}
			public event EventHandler<PropertyChangedEventArgs<Patient, string>> PatientNameChanged
			{
				add
				{
					if ((object)value != null)
					{
						Patient.InterlockedDelegateCombine(ref this.Events[3], value);
					}
				}
				remove
				{
					System.Delegate[] events;
					if ((object)value != null && (object)(events = this._events) != null)
					{
						Patient.InterlockedDelegateRemove(ref events[3], value);
					}
				}
			}
			protected void OnPatientNameChanged(string oldValue)
			{
				System.Delegate[] events;
				EventHandler<PropertyChangedEventArgs<Patient, string>> eventHandler;
				if ((object)(events = this._events) != null && (object)(eventHandler = (EventHandler<PropertyChangedEventArgs<Patient, string>>)events[3]) != null)
				{
					EventHandlerUtility.InvokeEventHandlerAsync<PropertyChangedEventArgs<Patient, string>>(eventHandler, this, new PropertyChangedEventArgs<Patient, string>(this, "PatientName", oldValue, this.PatientName), this._propertyChangedEventHandler);
				}
				else
				{
					this.OnPropertyChanged("PatientName");
				}
			}
			public event EventHandler<PropertyChangingEventArgs<Patient, Nullable<bool>>> IsSmokerChanging
			{
				add
				{
					if ((object)value != null)
					{
						Patient.InterlockedDelegateCombine(ref this.Events[4], value);
					}
				}
				remove
				{
					System.Delegate[] events;
					if ((object)value != null && (object)(events = this._events) != null)
					{
						Patient.InterlockedDelegateRemove(ref events[4], value);
					}
				}
			}
			protected bool OnIsSmokerChanging(Nullable<bool> newValue)
			{
				System.Delegate[] events;
				EventHandler<PropertyChangingEventArgs<Patient, Nullable<bool>>> eventHandler;
				if ((object)(events = this._events) != null && (object)(eventHandler = (EventHandler<PropertyChangingEventArgs<Patient, Nullable<bool>>>)events[4]) != null)
				{
					return EventHandlerUtility.InvokeCancelableEventHandler<PropertyChangingEventArgs<Patient, Nullable<bool>>>(eventHandler, this, new PropertyChangingEventArgs<Patient, Nullable<bool>>(this, "IsSmoker", this.IsSmoker, newValue));
				}
				return true;
			}
			public event EventHandler<PropertyChangedEventArgs<Patient, Nullable<bool>>> IsSmokerChanged
			{
				add
				{
					if ((object)value != null)
					{
						Patient.InterlockedDelegateCombine(ref this.Events[5], value);
					}
				}
				remove
				{
					System.Delegate[] events;
					if ((object)value != null && (object)(events = this._events) != null)
					{
						Patient.InterlockedDelegateRemove(ref events[5], value);
					}
				}
			}
			protected void OnIsSmokerChanged(Nullable<bool> oldValue)
			{
				System.Delegate[] events;
				EventHandler<PropertyChangedEventArgs<Patient, Nullable<bool>>> eventHandler;
				if ((object)(events = this._events) != null && (object)(eventHandler = (EventHandler<PropertyChangedEventArgs<Patient, Nullable<bool>>>)events[5]) != null)
				{
					EventHandlerUtility.InvokeEventHandlerAsync<PropertyChangedEventArgs<Patient, Nullable<bool>>>(eventHandler, this, new PropertyChangedEventArgs<Patient, Nullable<bool>>(this, "IsSmoker", oldValue, this.IsSmoker), this._propertyChangedEventHandler);
				}
				else
				{
					this.OnPropertyChanged("IsSmoker");
				}
			}
			#endregion // Patient Property Change Events
			#region Patient Abstract Properties
			public abstract ORMModel1Context Context
			{
				get;
			}
			[DataObjectField(false, false, false)]
			public abstract int PatientNr
			{
				get;
				set;
			}
			[DataObjectField(false, false, false)]
			public abstract string PatientName
			{
				get;
				set;
			}
			[DataObjectField(false, false, true)]
			public abstract Nullable<bool> IsSmoker
			{
				get;
				set;
			}
			[DataObjectField(false, false, true)]
			public abstract IEnumerable<DrugAllergy> DrugAllergyViaPatientCollection
			{
				get;
			}
			#endregion // Patient Abstract Properties
			#region Patient ToString Methods
			public override string ToString()
			{
				return this.ToString(null);
			}
			public virtual string ToString(IFormatProvider provider)
			{
				return string.Format(provider, @"Patient{0}{{{0}{1}PatientNr = ""{2}"",{0}{1}PatientName = ""{3}"",{0}{1}IsSmoker = ""{4}""{0}}}", Environment.NewLine, @"	", this.PatientNr, this.PatientName, this.IsSmoker);
			}
			#endregion // Patient ToString Methods
		}
		#endregion // Patient
		#region DrugAllergy
		[DataObject()]
		[System.CodeDom.Compiler.GeneratedCode("OIALtoPLiX", "1.0")]
		[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet=System.Runtime.InteropServices.CharSet.Auto)]
		public abstract partial class DrugAllergy : INotifyPropertyChanged, IHasORMModel1Context
		{
			protected DrugAllergy()
			{
			}
			#region DrugAllergy INotifyPropertyChanged Implementation
			private PropertyChangedEventHandler _propertyChangedEventHandler;
			[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
			event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
			{
				add
				{
					if ((object)value != null)
					{
						PropertyChangedEventHandler currentHandler;
						while ((object)System.Threading.Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this._propertyChangedEventHandler, (PropertyChangedEventHandler)System.Delegate.Combine(currentHandler = this._propertyChangedEventHandler, value), currentHandler) != (object)currentHandler)
						{
						}
					}
				}
				remove
				{
					if ((object)value != null)
					{
						PropertyChangedEventHandler currentHandler;
						while ((object)System.Threading.Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this._propertyChangedEventHandler, (PropertyChangedEventHandler)System.Delegate.Remove(currentHandler = this._propertyChangedEventHandler, value), currentHandler) != (object)currentHandler)
						{
						}
					}
				}
			}
			private void OnPropertyChanged(string propertyName)
			{
				PropertyChangedEventHandler eventHandler;
				if ((object)(eventHandler = this._propertyChangedEventHandler) != null)
				{
					EventHandlerUtility.InvokeEventHandlerAsync(eventHandler, this, new PropertyChangedEventArgs(propertyName));
				}
			}
			#endregion // DrugAllergy INotifyPropertyChanged Implementation
			#region DrugAllergy Property Change Events
			private System.Delegate[] _events;
			private System.Delegate[] Events
			{
				get
				{
					System.Delegate[] localEvents;
					return (localEvents = this._events) ?? System.Threading.Interlocked.CompareExchange<System.Delegate[]>(ref this._events, localEvents = new System.Delegate[4], null) ?? localEvents;
				}
			}
			private static void InterlockedDelegateCombine(ref System.Delegate location, System.Delegate value)
			{
				System.Delegate currentHandler;
				while ((object)System.Threading.Interlocked.CompareExchange<System.Delegate>(ref location, System.Delegate.Combine(currentHandler = location, value), currentHandler) != (object)currentHandler)
				{
				}
			}
			private static void InterlockedDelegateRemove(ref System.Delegate location, System.Delegate value)
			{
				System.Delegate currentHandler;
				while ((object)System.Threading.Interlocked.CompareExchange<System.Delegate>(ref location, System.Delegate.Remove(currentHandler = location, value), currentHandler) != (object)currentHandler)
				{
				}
			}
			public event EventHandler<PropertyChangingEventArgs<DrugAllergy, string>> DrugNameChanging
			{
				add
				{
					if ((object)value != null)
					{
						DrugAllergy.InterlockedDelegateCombine(ref this.Events[0], value);
					}
				}
				remove
				{
					System.Delegate[] events;
					if ((object)value != null && (object)(events = this._events) != null)
					{
						DrugAllergy.InterlockedDelegateRemove(ref events[0], value);
					}
				}
			}
			protected bool OnDrugNameChanging(string newValue)
			{
				System.Delegate[] events;
				EventHandler<PropertyChangingEventArgs<DrugAllergy, string>> eventHandler;
				if ((object)(events = this._events) != null && (object)(eventHandler = (EventHandler<PropertyChangingEventArgs<DrugAllergy, string>>)events[0]) != null)
				{
					return EventHandlerUtility.InvokeCancelableEventHandler<PropertyChangingEventArgs<DrugAllergy, string>>(eventHandler, this, new PropertyChangingEventArgs<DrugAllergy, string>(this, "DrugName", this.DrugName, newValue));
				}
				return true;
			}
			public event EventHandler<PropertyChangedEventArgs<DrugAllergy, string>> DrugNameChanged
			{
				add
				{
					if ((object)value != null)
					{
						DrugAllergy.InterlockedDelegateCombine(ref this.Events[1], value);
					}
				}
				remove
				{
					System.Delegate[] events;
					if ((object)value != null && (object)(events = this._events) != null)
					{
						DrugAllergy.InterlockedDelegateRemove(ref events[1], value);
					}
				}
			}
			protected void OnDrugNameChanged(string oldValue)
			{
				System.Delegate[] events;
				EventHandler<PropertyChangedEventArgs<DrugAllergy, string>> eventHandler;
				if ((object)(events = this._events) != null && (object)(eventHandler = (EventHandler<PropertyChangedEventArgs<DrugAllergy, string>>)events[1]) != null)
				{
					EventHandlerUtility.InvokeEventHandlerAsync<PropertyChangedEventArgs<DrugAllergy, string>>(eventHandler, this, new PropertyChangedEventArgs<DrugAllergy, string>(this, "DrugName", oldValue, this.DrugName), this._propertyChangedEventHandler);
				}
				else
				{
					this.OnPropertyChanged("DrugName");
				}
			}
			public event EventHandler<PropertyChangingEventArgs<DrugAllergy, Patient>> PatientChanging
			{
				add
				{
					if ((object)value != null)
					{
						DrugAllergy.InterlockedDelegateCombine(ref this.Events[2], value);
					}
				}
				remove
				{
					System.Delegate[] events;
					if ((object)value != null && (object)(events = this._events) != null)
					{
						DrugAllergy.InterlockedDelegateRemove(ref events[2], value);
					}
				}
			}
			protected bool OnPatientChanging(Patient newValue)
			{
				System.Delegate[] events;
				EventHandler<PropertyChangingEventArgs<DrugAllergy, Patient>> eventHandler;
				if ((object)(events = this._events) != null && (object)(eventHandler = (EventHandler<PropertyChangingEventArgs<DrugAllergy, Patient>>)events[2]) != null)
				{
					return EventHandlerUtility.InvokeCancelableEventHandler<PropertyChangingEventArgs<DrugAllergy, Patient>>(eventHandler, this, new PropertyChangingEventArgs<DrugAllergy, Patient>(this, "Patient", this.Patient, newValue));
				}
				return true;
			}
			public event EventHandler<PropertyChangedEventArgs<DrugAllergy, Patient>> PatientChanged
			{
				add
				{
					if ((object)value != null)
					{
						DrugAllergy.InterlockedDelegateCombine(ref this.Events[3], value);
					}
				}
				remove
				{
					System.Delegate[] events;
					if ((object)value != null && (object)(events = this._events) != null)
					{
						DrugAllergy.InterlockedDelegateRemove(ref events[3], value);
					}
				}
			}
			protected void OnPatientChanged(Patient oldValue)
			{
				System.Delegate[] events;
				EventHandler<PropertyChangedEventArgs<DrugAllergy, Patient>> eventHandler;
				if ((object)(events = this._events) != null && (object)(eventHandler = (EventHandler<PropertyChangedEventArgs<DrugAllergy, Patient>>)events[3]) != null)
				{
					EventHandlerUtility.InvokeEventHandlerAsync<PropertyChangedEventArgs<DrugAllergy, Patient>>(eventHandler, this, new PropertyChangedEventArgs<DrugAllergy, Patient>(this, "Patient", oldValue, this.Patient), this._propertyChangedEventHandler);
				}
				else
				{
					this.OnPropertyChanged("Patient");
				}
			}
			#endregion // DrugAllergy Property Change Events
			#region DrugAllergy Abstract Properties
			public abstract ORMModel1Context Context
			{
				get;
			}
			[DataObjectField(false, false, false)]
			public abstract string DrugName
			{
				get;
				set;
			}
			[DataObjectField(false, false, false)]
			public abstract Patient Patient
			{
				get;
				set;
			}
			#endregion // DrugAllergy Abstract Properties
			#region DrugAllergy ToString Methods
			public override string ToString()
			{
				return this.ToString(null);
			}
			public virtual string ToString(IFormatProvider provider)
			{
				return string.Format(provider, @"DrugAllergy{0}{{{0}{1}DrugName = ""{2}"",{0}{1}Patient = {3}{0}}}", Environment.NewLine, @"	", this.DrugName, "TODO: Recursively call ToString for customTypes...");
			}
			#endregion // DrugAllergy ToString Methods
		}
		#endregion // DrugAllergy
		#region IHasORMModel1Context
		[System.CodeDom.Compiler.GeneratedCode("OIALtoPLiX", "1.0")]
		public interface IHasORMModel1Context
		{
			ORMModel1Context Context
			{
				get;
			}
		}
		#endregion // IHasORMModel1Context
		#region IORMModel1Context
		[System.CodeDom.Compiler.GeneratedCode("OIALtoPLiX", "1.0")]
		public interface IORMModel1Context
		{
			Patient GetPatientByPatientNr(int patientNr);
			bool TryGetPatientByPatientNr(int patientNr, out Patient patient);
			DrugAllergy GetDrugAllergyByPatientAndDrugName(Patient patient, string drugName);
			bool TryGetDrugAllergyByPatientAndDrugName(Patient patient, string drugName, out DrugAllergy drugAllergy);
			Patient CreatePatient(int patientNr, string patientName);
			IEnumerable<Patient> PatientCollection
			{
				get;
			}
			DrugAllergy CreateDrugAllergy(string drugName, Patient patient);
			IEnumerable<DrugAllergy> DrugAllergyCollection
			{
				get;
			}
		}
		#endregion // IORMModel1Context
	}
}
