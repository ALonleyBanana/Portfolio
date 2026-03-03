using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Xml;
namespace Lab1App
{
	namespace ORMModel1
	{
		#region ORMModel1Context
		[System.CodeDom.Compiler.GeneratedCode("OIALtoPLiX", "1.0")]
		[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet=System.Runtime.InteropServices.CharSet.Auto)]
		public sealed class ORMModel1Context : IORMModel1Context
		{
			public ORMModel1Context()
			{
				Dictionary<RuntimeTypeHandle, object> constraintEnforcementCollectionCallbacksByTypeDictionary = this._ContraintEnforcementCollectionCallbacksByTypeDictionary = new Dictionary<RuntimeTypeHandle, object>(1, RuntimeTypeHandleEqualityComparer.Instance);
				constraintEnforcementCollectionCallbacksByTypeDictionary.Add(typeof(ConstraintEnforcementCollection<Patient, DrugAllergy>).TypeHandle, new ConstraintEnforcementCollectionCallbacks<Patient, DrugAllergy>(new PotentialCollectionModificationCallback<Patient, DrugAllergy>(this.OnPatientDrugAllergyViaPatientCollectionAdding), new CommittedCollectionModificationCallback<Patient, DrugAllergy>(this.OnPatientDrugAllergyViaPatientCollectionAdded), null, new CommittedCollectionModificationCallback<Patient, DrugAllergy>(this.OnPatientDrugAllergyViaPatientCollectionRemoved)));
				this._PatientReadOnlyCollection = new ReadOnlyCollection<Patient>(this._PatientList = new List<Patient>());
				this._DrugAllergyReadOnlyCollection = new ReadOnlyCollection<DrugAllergy>(this._DrugAllergyList = new List<DrugAllergy>());
			}
			#region Exception Helpers
			private static ArgumentException GetDifferentContextsException()
			{
				return ORMModel1Context.GetDifferentContextsException("value");
			}
			[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2208:InstantiateArgumentExceptionsCorrectly")]
			private static ArgumentException GetDifferentContextsException(string paramName)
			{
				return new ArgumentException("All objects in a relationship must be part of the same Context.", paramName);
			}
			private static ArgumentException GetConstraintEnforcementFailedException(string paramName)
			{
				return new ArgumentException("Argument failed constraint enforcement.", paramName);
			}
			#endregion // Exception Helpers
			#region Lookup and External Constraint Enforcement
			private readonly Dictionary<int, Patient> _PatientPatientNrDictionary = new Dictionary<int, Patient>();
			public Patient GetPatientByPatientNr(int patientNr)
			{
				return this._PatientPatientNrDictionary[patientNr];
			}
			public bool TryGetPatientByPatientNr(int patientNr, out Patient patient)
			{
				return this._PatientPatientNrDictionary.TryGetValue(patientNr, out patient);
			}
			private readonly Dictionary<Tuple<Patient, string>, DrugAllergy> _DrugAllergyPatientAndDrugNameDictionary = new Dictionary<Tuple<Patient, string>, DrugAllergy>();
			public DrugAllergy GetDrugAllergyByPatientAndDrugName(Patient patient, string drugName)
			{
				return this._DrugAllergyPatientAndDrugNameDictionary[Tuple.CreateTuple<Patient, string>(patient, drugName)];
			}
			public bool TryGetDrugAllergyByPatientAndDrugName(Patient patient, string drugName, out DrugAllergy drugAllergy)
			{
				return this._DrugAllergyPatientAndDrugNameDictionary.TryGetValue(Tuple.CreateTuple<Patient, string>(patient, drugName), out drugAllergy);
			}
			private bool OnPatientAndDrugNameChanging(DrugAllergy instance, Tuple<Patient, string> newValue)
			{
				if ((object)newValue != null)
				{
					DrugAllergy currentInstance;
					if (this._DrugAllergyPatientAndDrugNameDictionary.TryGetValue(newValue, out currentInstance))
					{
						return (object)currentInstance == (object)instance;
					}
				}
				return true;
			}
			private void OnPatientAndDrugNameChanged(DrugAllergy instance, Tuple<Patient, string> oldValue, Tuple<Patient, string> newValue)
			{
				if ((object)oldValue != null)
				{
					this._DrugAllergyPatientAndDrugNameDictionary.Remove(oldValue);
				}
				if ((object)newValue != null)
				{
					this._DrugAllergyPatientAndDrugNameDictionary.Add(newValue, instance);
				}
			}
			#endregion // Lookup and External Constraint Enforcement
			#region ConstraintEnforcementCollection
			private delegate bool PotentialCollectionModificationCallback<TClass, TProperty>(TClass instance, TProperty item)
				where TClass : class, IHasORMModel1Context;
			private delegate void CommittedCollectionModificationCallback<TClass, TProperty>(TClass instance, TProperty item)
				where TClass : class, IHasORMModel1Context;
			[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet=System.Runtime.InteropServices.CharSet.Auto)]
			private sealed class ConstraintEnforcementCollectionCallbacks<TClass, TProperty>
				where TClass : class, IHasORMModel1Context
			{
				public ConstraintEnforcementCollectionCallbacks(PotentialCollectionModificationCallback<TClass, TProperty> adding, CommittedCollectionModificationCallback<TClass, TProperty> added, PotentialCollectionModificationCallback<TClass, TProperty> removing, CommittedCollectionModificationCallback<TClass, TProperty> removed)
				{
					this.Adding = adding;
					this.Added = added;
					this.Removing = removing;
					this.Removed = removed;
				}
				public readonly PotentialCollectionModificationCallback<TClass, TProperty> Adding;
				public readonly CommittedCollectionModificationCallback<TClass, TProperty> Added;
				public readonly PotentialCollectionModificationCallback<TClass, TProperty> Removing;
				public readonly CommittedCollectionModificationCallback<TClass, TProperty> Removed;
			}
			private ConstraintEnforcementCollectionCallbacks<TClass, TProperty> GetConstraintEnforcementCollectionCallbacks<TClass, TProperty>()
				where TClass : class, IHasORMModel1Context
			{
				return (ConstraintEnforcementCollectionCallbacks<TClass, TProperty>)this._ContraintEnforcementCollectionCallbacksByTypeDictionary[typeof(ConstraintEnforcementCollection<TClass, TProperty>).TypeHandle];
			}
			[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet=System.Runtime.InteropServices.CharSet.Auto)]
			private sealed class RuntimeTypeHandleEqualityComparer : IEqualityComparer<RuntimeTypeHandle>
			{
				public static readonly RuntimeTypeHandleEqualityComparer Instance = new RuntimeTypeHandleEqualityComparer();
				private RuntimeTypeHandleEqualityComparer()
				{
				}
				public bool Equals(RuntimeTypeHandle x, RuntimeTypeHandle y)
				{
					return x.Equals(y);
				}
				public int GetHashCode(RuntimeTypeHandle obj)
				{
					return obj.GetHashCode();
				}
			}
			private readonly Dictionary<RuntimeTypeHandle, object> _ContraintEnforcementCollectionCallbacksByTypeDictionary;
			[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet=System.Runtime.InteropServices.CharSet.Auto)]
			private sealed class ConstraintEnforcementCollection<TClass, TProperty> : ICollection<TProperty>
				where TClass : class, IHasORMModel1Context
			{
				private readonly TClass _Instance;
				private readonly List<TProperty> _List = new List<TProperty>();
				public ConstraintEnforcementCollection(TClass instance)
				{
					this._Instance = instance;
				}
				private System.Collections.IEnumerator GetNonGenericEnumerator()
				{
					return this.GetEnumerator();
				}
				System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
				{
					return this.GetNonGenericEnumerator();
				}
				public IEnumerator<TProperty> GetEnumerator()
				{
					return this._List.GetEnumerator();
				}
				public void Add(TProperty item)
				{
					if (item == null)
					{
						throw new ArgumentNullException("item");
					}
					TClass instance = this._Instance;
					ConstraintEnforcementCollectionCallbacks<TClass, TProperty> callbacks = instance.Context.GetConstraintEnforcementCollectionCallbacks<TClass, TProperty>();
					PotentialCollectionModificationCallback<TClass, TProperty> adding = callbacks.Adding;
					if ((object)adding == null || adding(instance, item))
					{
						this._List.Add(item);
						CommittedCollectionModificationCallback<TClass, TProperty> added = callbacks.Added;
						if ((object)added != null)
						{
							added(instance, item);
						}
					}
				}
				public bool Remove(TProperty item)
				{
					if (item == null)
					{
						throw new ArgumentNullException("item");
					}
					TClass instance = this._Instance;
					ConstraintEnforcementCollectionCallbacks<TClass, TProperty> callbacks = instance.Context.GetConstraintEnforcementCollectionCallbacks<TClass, TProperty>();
					PotentialCollectionModificationCallback<TClass, TProperty> removing = callbacks.Removing;
					if ((object)removing == null || removing(instance, item))
					{
						if (this._List.Remove(item))
						{
							CommittedCollectionModificationCallback<TClass, TProperty> removed = callbacks.Removed;
							if ((object)removed != null)
							{
								removed(instance, item);
							}
							return true;
						}
					}
					return false;
				}
				public void Clear()
				{
					List<TProperty> list = this._List;
					for (int i = list.Count - 1; i > 0; --i)
					{
						this.Remove(list[i]);
					}
				}
				public bool Contains(TProperty item)
				{
					return item != null && this._List.Contains(item);
				}
				public void CopyTo(TProperty[] array, int arrayIndex)
				{
					this._List.CopyTo(array, arrayIndex);
				}
				public int Count
				{
					get
					{
						return this._List.Count;
					}
				}
				public bool IsReadOnly
				{
					get
					{
						return false;
					}
				}
			}
			#endregion // ConstraintEnforcementCollection
			#region Patient
			public Patient CreatePatient(int patientNr, string patientName)
			{
				if ((object)patientName == null)
				{
					throw new ArgumentNullException("patientName");
				}
				if (!this.OnPatientPatientNrChanging(null, patientNr))
				{
					throw ORMModel1Context.GetConstraintEnforcementFailedException("patientNr");
				}
				if (!this.OnPatientPatientNameChanging(null, patientName))
				{
					throw ORMModel1Context.GetConstraintEnforcementFailedException("patientName");
				}
				return new PatientImpl(this, patientNr, patientName);
			}
			private bool OnPatientPatientNrChanging(Patient instance, int newValue)
			{
				Patient currentInstance;
				if (this._PatientPatientNrDictionary.TryGetValue(newValue, out currentInstance))
				{
					if ((object)currentInstance != (object)instance)
					{
						return false;
					}
				}
				return true;
			}
			private void OnPatientPatientNrChanged(Patient instance, Nullable<int> oldValue)
			{
				this._PatientPatientNrDictionary.Add(instance.PatientNr, instance);
				if (oldValue.HasValue)
				{
					this._PatientPatientNrDictionary.Remove(oldValue.GetValueOrDefault());
				}
			}
			private bool OnPatientPatientNameChanging(Patient instance, string newValue)
			{
				return true;
			}
			private bool OnPatientIsSmokerChanging(Patient instance, Nullable<bool> newValue)
			{
				return true;
			}
			private bool OnPatientDrugAllergyViaPatientCollectionAdding(Patient instance, DrugAllergy item)
			{
				if ((object)this != (object)item.Context)
				{
					throw ORMModel1Context.GetDifferentContextsException("item");
				}
				return true;
			}
			private void OnPatientDrugAllergyViaPatientCollectionAdded(Patient instance, DrugAllergy item)
			{
				item.Patient = instance;
			}
			private void OnPatientDrugAllergyViaPatientCollectionRemoved(Patient instance, DrugAllergy item)
			{
				if ((object)item.Patient == (object)instance)
				{
					item.Patient = null;
				}
			}
			private readonly List<Patient> _PatientList;
			private readonly ReadOnlyCollection<Patient> _PatientReadOnlyCollection;
			public IEnumerable<Patient> PatientCollection
			{
				get
				{
					return this._PatientReadOnlyCollection;
				}
			}
			#region PatientImpl
			[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet=System.Runtime.InteropServices.CharSet.Auto)]
			private sealed class PatientImpl : Patient
			{
				public PatientImpl(ORMModel1Context context, int patientNr, string patientName)
				{
					this._Context = context;
					this._DrugAllergyViaPatientCollection = new ConstraintEnforcementCollection<Patient, DrugAllergy>(this);
					this._PatientNr = patientNr;
					context.OnPatientPatientNrChanged(this, null);
					this._PatientName = patientName;
					context._PatientList.Add(this);
				}
				private readonly ORMModel1Context _Context;
				public sealed override ORMModel1Context Context
				{
					get
					{
						return this._Context;
					}
				}
				private int _PatientNr;
				public sealed override int PatientNr
				{
					get
					{
						return this._PatientNr;
					}
					set
					{
						int oldValue = this._PatientNr;
						if (oldValue != value)
						{
							if (this._Context.OnPatientPatientNrChanging(this, value) && base.OnPatientNrChanging(value))
							{
								this._PatientNr = value;
								this._Context.OnPatientPatientNrChanged(this, oldValue);
								base.OnPatientNrChanged(oldValue);
							}
						}
					}
				}
				private string _PatientName;
				public sealed override string PatientName
				{
					get
					{
						return this._PatientName;
					}
					set
					{
						if ((object)value == null)
						{
							throw new ArgumentNullException("value");
						}
						string oldValue = this._PatientName;
						if ((object)oldValue != (object)value && !value.Equals(oldValue))
						{
							if (this._Context.OnPatientPatientNameChanging(this, value) && base.OnPatientNameChanging(value))
							{
								this._PatientName = value;
								base.OnPatientNameChanged(oldValue);
							}
						}
					}
				}
				private Nullable<bool> _IsSmoker;
				public sealed override Nullable<bool> IsSmoker
				{
					get
					{
						return this._IsSmoker;
					}
					set
					{
						Nullable<bool> oldValue = this._IsSmoker;
						if (oldValue.GetValueOrDefault() != value.GetValueOrDefault() || oldValue.HasValue != value.HasValue)
						{
							if (this._Context.OnPatientIsSmokerChanging(this, value) && base.OnIsSmokerChanging(value))
							{
								this._IsSmoker = value;
								base.OnIsSmokerChanged(oldValue);
							}
						}
					}
				}
				private readonly IEnumerable<DrugAllergy> _DrugAllergyViaPatientCollection;
				public sealed override IEnumerable<DrugAllergy> DrugAllergyViaPatientCollection
				{
					get
					{
						return this._DrugAllergyViaPatientCollection;
					}
				}
			}
			#endregion // PatientImpl
			#endregion // Patient
			#region DrugAllergy
			public DrugAllergy CreateDrugAllergy(string drugName, Patient patient)
			{
				if ((object)drugName == null)
				{
					throw new ArgumentNullException("drugName");
				}
				if ((object)patient == null)
				{
					throw new ArgumentNullException("patient");
				}
				if (!this.OnDrugAllergyDrugNameChanging(null, drugName))
				{
					throw ORMModel1Context.GetConstraintEnforcementFailedException("drugName");
				}
				if (!this.OnDrugAllergyPatientChanging(null, patient))
				{
					throw ORMModel1Context.GetConstraintEnforcementFailedException("patient");
				}
				return new DrugAllergyImpl(this, drugName, patient);
			}
			private bool OnDrugAllergyDrugNameChanging(DrugAllergy instance, string newValue)
			{
				if ((object)instance != null)
				{
					if (!this.OnPatientAndDrugNameChanging(instance, Tuple.CreateTuple<Patient, string>(instance.Patient, newValue)))
					{
						return false;
					}
				}
				return true;
			}
			private void OnDrugAllergyDrugNameChanged(DrugAllergy instance, string oldValue)
			{
				Tuple<Patient, string> PatientAndDrugNameOldValueTuple;
				if ((object)oldValue != null)
				{
					PatientAndDrugNameOldValueTuple = Tuple.CreateTuple<Patient, string>(instance.Patient, oldValue);
				}
				else
				{
					PatientAndDrugNameOldValueTuple = null;
				}
				this.OnPatientAndDrugNameChanged(instance, PatientAndDrugNameOldValueTuple, Tuple.CreateTuple<Patient, string>(instance.Patient, instance.DrugName));
			}
			private bool OnDrugAllergyPatientChanging(DrugAllergy instance, Patient newValue)
			{
				if ((object)this != (object)newValue.Context)
				{
					throw ORMModel1Context.GetDifferentContextsException();
				}
				if ((object)instance != null)
				{
					if (!this.OnPatientAndDrugNameChanging(instance, Tuple.CreateTuple<Patient, string>(newValue, instance.DrugName)))
					{
						return false;
					}
				}
				return true;
			}
			private void OnDrugAllergyPatientChanged(DrugAllergy instance, Patient oldValue)
			{
				((ICollection<DrugAllergy>)instance.Patient.DrugAllergyViaPatientCollection).Add(instance);
				Tuple<Patient, string> PatientAndDrugNameOldValueTuple;
				if ((object)oldValue != null)
				{
					((ICollection<DrugAllergy>)oldValue.DrugAllergyViaPatientCollection).Remove(instance);
					PatientAndDrugNameOldValueTuple = Tuple.CreateTuple<Patient, string>(oldValue, instance.DrugName);
				}
				else
				{
					PatientAndDrugNameOldValueTuple = null;
				}
				this.OnPatientAndDrugNameChanged(instance, PatientAndDrugNameOldValueTuple, Tuple.CreateTuple<Patient, string>(instance.Patient, instance.DrugName));
			}
			private readonly List<DrugAllergy> _DrugAllergyList;
			private readonly ReadOnlyCollection<DrugAllergy> _DrugAllergyReadOnlyCollection;
			public IEnumerable<DrugAllergy> DrugAllergyCollection
			{
				get
				{
					return this._DrugAllergyReadOnlyCollection;
				}
			}
			#region DrugAllergyImpl
			[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Auto, CharSet=System.Runtime.InteropServices.CharSet.Auto)]
			private sealed class DrugAllergyImpl : DrugAllergy
			{
				public DrugAllergyImpl(ORMModel1Context context, string drugName, Patient patient)
				{
					this._Context = context;
					this._DrugName = drugName;
					context.OnDrugAllergyDrugNameChanged(this, null);
					this._Patient = patient;
					context.OnDrugAllergyPatientChanged(this, null);
					context._DrugAllergyList.Add(this);
				}
				private readonly ORMModel1Context _Context;
				public sealed override ORMModel1Context Context
				{
					get
					{
						return this._Context;
					}
				}
				private string _DrugName;
				public sealed override string DrugName
				{
					get
					{
						return this._DrugName;
					}
					set
					{
						if ((object)value == null)
						{
							throw new ArgumentNullException("value");
						}
						string oldValue = this._DrugName;
						if ((object)oldValue != (object)value && !value.Equals(oldValue))
						{
							if (this._Context.OnDrugAllergyDrugNameChanging(this, value) && base.OnDrugNameChanging(value))
							{
								this._DrugName = value;
								this._Context.OnDrugAllergyDrugNameChanged(this, oldValue);
								base.OnDrugNameChanged(oldValue);
							}
						}
					}
				}
				private Patient _Patient;
				public sealed override Patient Patient
				{
					get
					{
						return this._Patient;
					}
					set
					{
						if ((object)value == null)
						{
							throw new ArgumentNullException("value");
						}
						Patient oldValue = this._Patient;
						if ((object)oldValue != (object)value)
						{
							if (this._Context.OnDrugAllergyPatientChanging(this, value) && base.OnPatientChanging(value))
							{
								this._Patient = value;
								this._Context.OnDrugAllergyPatientChanged(this, oldValue);
								base.OnPatientChanged(oldValue);
							}
						}
					}
				}
			}
			#endregion // DrugAllergyImpl
			#endregion // DrugAllergy
		}
		#endregion // ORMModel1Context
	}
}
