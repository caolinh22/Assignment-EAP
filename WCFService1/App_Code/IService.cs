using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{
	[OperationContract]
	string AddData(Student std);

	[OperationContract]
	string UpdateData(Student std);

	[OperationContract]
	string GetData(string value);

	[OperationContract]
	DataSet GetDataRecord(Student std);

	// TODO: Add your service operations here
}

// Use a data contract as illustrated in the sample below to add composite types to service operations.
[DataContract]
public class Student
{
	string _name;
	int id;
	DateTime birth;
	string gender;
	string email;
	string detail;

	[DataMember]
	public string Name
	{
		get { return _name; }
		set { _name = value; }
	}
	[DataMember]
	public int ID
	{
		get { return id; }
		set { id = value; }
	}[DataMember]
	public DateTime Birth
	{
		get { return birth; }
		set { birth = value; }
	}[DataMember]
	public string Gender
	{
		get { return gender; }
		set { gender = value; }
	}[DataMember]
	public string Email
	{
		get { return email; }
		set { email = value; }
	}
	[DataMember]
	public string Detail
	{
		get { return detail; }
		set { detail = value; }
	}

	
}
