
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace BookingGatewayService.Tests
{
    /// <summary>
    /// !!! WARNING 
    /// !!! Project structure test.
    /// !!! DON'T CHANGE IT! 
    /// !!! Changes may cause the solution to be rejected.
    /// </summary>
    public class BookingGatewayRepositoryStructureTest
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// !!! WARNING 
        /// !!! Project structure test.
        /// !!! DON'T CHANGE IT! 
        /// !!! Changes may cause the solution to be rejected.
        /// </summary>
        [Test]
        public void StructureTest()
        {
            
            Assembly assembly;
            Type type;
            Type methodReturnType;
            MethodInfo method;
            int methodsCount;
            ParameterInfo parameter;
            int parametersCount;
            int constructorsCount;
            List<string> constructorParameterNameTypeDictionary;
            ConstructorInfo constructor;
            int fieldsCount;
            FieldInfo field;
            Type fieldReturnType;
            PropertyInfo property;
            int propertiesCount;
            Type propertyReturnType;
            assembly = Assembly.Load(Decode("Qm9va2luZ0dhdGV3YXlSZXBvc2l0b3J5LCBWZXJzaW9uPTEuMC4wLjAsIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49bnVsbA==") /*"BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"*/ );
            Assert.IsNotNull(assembly, "Missing  BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("SURCUmVwb3NpdG9yeQ==") /*"IDBRepository"*/ );
                Assert.IsNotNull(type, "Missing assembly: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository");
                    Assert.IsTrue(type.IsAbstract, "assembly: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository is not abstract class");
                    Assert.IsTrue(type.IsInterface, "assembly: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository is not interface");
                    Assert.IsTrue(type.IsPublic, "assembly: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("U2F2ZUJvb2tpbmc=") /*"SaveBooking"*/ );                            Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository.SaveBooking(TransactionData transaction) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository.SaveBooking(TransactionData transaction) is not public");
                            Assert.IsTrue(method.IsAbstract, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository.SaveBooking(TransactionData transaction) is not abstract");
                            Assert.IsTrue(method.IsVirtual, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository.SaveBooking(TransactionData transaction) is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Void",methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository.SaveBooking(TransactionData transaction) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository.SaveBooking(TransactionData transaction) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("dHJhbnNhY3Rpb24=") /*"transaction"*/  && x.ParameterType.FullName == "BookingGatewayRepository.Model.TransactionData");
                                Assert.IsNotNull(parameter, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository.SaveBooking(TransactionData transaction) parameter transaction does not exists or does not have type BookingGatewayRepository.Model.TransactionData");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("R2V0U3RhdHVzZXM=") /*"GetStatuses"*/ );                            Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository.GetStatuses(String[] uniqueTransactionRefs) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository.GetStatuses(String[] uniqueTransactionRefs) is not public");
                            Assert.IsTrue(method.IsAbstract, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository.GetStatuses(String[] uniqueTransactionRefs) is not abstract");
                            Assert.IsTrue(method.IsVirtual, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository.GetStatuses(String[] uniqueTransactionRefs) is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("BookingGatewayRepository.Model.TransactionStatus[]",methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository.GetStatuses(String[] uniqueTransactionRefs) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository.GetStatuses(String[] uniqueTransactionRefs) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("dW5pcXVlVHJhbnNhY3Rpb25SZWZz") /*"uniqueTransactionRefs"*/  && x.ParameterType.FullName == "System.String[]");
                                Assert.IsNotNull(parameter, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.IDBRepository.GetStatuses(String[] uniqueTransactionRefs) parameter uniqueTransactionRefs does not exists or does not have type System.String[]");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("VHJhbnNhY3Rpb25EYXRh") /*"TransactionData"*/ );
                Assert.IsNotNull(type, "Missing assembly: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData");
                    Assert.IsTrue(type.IsClass, "assembly: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData is not public class");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData() does not exists");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("QW1vdW50") /*"Amount"*/ );
                            Assert.IsNotNull(property, "property: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.Decimal Amount does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0Ftb3VudA==") /*"get_Amount"*/ );                                Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_Amount() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_Amount() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Decimal",methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_Amount() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0Ftb3VudA==") /*"get_Amount"*/ );                                Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_Amount() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_Amount() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Decimal",methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_Amount() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.Decimal",propertyReturnType.FullName, "property: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.Decimal Amount  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("VHJhbnNhY3Rpb25UaXRsZQ==") /*"TransactionTitle"*/ );
                            Assert.IsNotNull(property, "property: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.String TransactionTitle does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1RyYW5zYWN0aW9uVGl0bGU=") /*"get_TransactionTitle"*/ );                                Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_TransactionTitle() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_TransactionTitle() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_TransactionTitle() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1RyYW5zYWN0aW9uVGl0bGU=") /*"get_TransactionTitle"*/ );                                Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_TransactionTitle() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_TransactionTitle() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_TransactionTitle() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.String TransactionTitle  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("U291cmNlQWNjb3VudE5v") /*"SourceAccountNo"*/ );
                            Assert.IsNotNull(property, "property: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.String SourceAccountNo does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1NvdXJjZUFjY291bnRObw==") /*"get_SourceAccountNo"*/ );                                Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_SourceAccountNo() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_SourceAccountNo() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_SourceAccountNo() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1NvdXJjZUFjY291bnRObw==") /*"get_SourceAccountNo"*/ );                                Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_SourceAccountNo() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_SourceAccountNo() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_SourceAccountNo() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.String SourceAccountNo  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("RGVzdEFjY291bnRObw==") /*"DestAccountNo"*/ );
                            Assert.IsNotNull(property, "property: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.String DestAccountNo does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0Rlc3RBY2NvdW50Tm8=") /*"get_DestAccountNo"*/ );                                Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_DestAccountNo() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_DestAccountNo() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_DestAccountNo() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0Rlc3RBY2NvdW50Tm8=") /*"get_DestAccountNo"*/ );                                Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_DestAccountNo() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_DestAccountNo() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_DestAccountNo() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.String DestAccountNo  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("VW5pcXVlUmVm") /*"UniqueRef"*/ );
                            Assert.IsNotNull(property, "property: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.String UniqueRef does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1VuaXF1ZVJlZg==") /*"get_UniqueRef"*/ );                                Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_UniqueRef() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_UniqueRef() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_UniqueRef() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1VuaXF1ZVJlZg==") /*"get_UniqueRef"*/ );                                Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_UniqueRef() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_UniqueRef() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.get_UniqueRef() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionData.String UniqueRef  type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.Name == Decode("VHJhbnNhY3Rpb25TdGF0dXM=") /*"TransactionStatus"*/ );
                Assert.IsNotNull(type, "Missing assembly: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus");
                    Assert.IsTrue(type.IsClass, "assembly: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus is not public class");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus() does not exists");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("VW5pcXVlUmVm") /*"UniqueRef"*/ );
                            Assert.IsNotNull(property, "property: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.String UniqueRef does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1VuaXF1ZVJlZg==") /*"get_UniqueRef"*/ );                                Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.get_UniqueRef() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.get_UniqueRef() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.get_UniqueRef() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1VuaXF1ZVJlZg==") /*"get_UniqueRef"*/ );                                Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.get_UniqueRef() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.get_UniqueRef() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.get_UniqueRef() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.String UniqueRef  type has changed");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("U3RhdHVz") /*"Status"*/ );
                            Assert.IsNotNull(property, "property: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.String Status does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1N0YXR1cw==") /*"get_Status"*/ );                                Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.get_Status() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.get_Status() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.get_Status() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1N0YXR1cw==") /*"get_Status"*/ );                                Assert.IsNotNull(method, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.get_Status() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.get_Status() is not public");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.String",methodReturnType.FullName, "method: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.get_Status() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.String",propertyReturnType.FullName, "property: BookingGatewayRepository, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:BookingGatewayRepository.Model.TransactionStatus.String Status  type has changed");


        }

        /// <summary>
        /// !!! WARNING 
        /// !!! Project structure test.
        /// !!! DON'T CHANGE IT! 
        /// !!! Changes may cause the solution to be rejected.
        /// </summary>
        private string Decode(string text)
        {
            return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(text));
        }
    }
}
