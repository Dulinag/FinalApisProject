# FinalApisProject

This is a simple web application that allows users to manage patients, doctors, and appointments through a RESTful API. The application was built using C# and the Entity Framework Core, which provides an object-relational mapping (ORM) between the C# code and the SQL database. The application includes controller files for each entity (patient, doctor, appointment), which handle HTTP requests and responses, such as GET, POST, PUT, and DELETE.

The Patients table contains information about patients, including their name, date of birth, gender, address, phone number, and email. The Doctors table contains information about doctors, including their name, specialization, phone number, and email. The Appointments table connects patients and doctors, with information about the appointment date and type.

The application uses a MySQL database, which is configured in the MyFirstAPIDBContext class. The connection string is stored in the appsettings.json file, which can be modified to point to a different database.

The API can be tested using an HTTP client, such as Postman
<h1>HTTP Methods and API endpoints:</h1>
<h2>GET:</h2>                                                                                                                                                              <ul>
  <li>Get Doctor -> /api/doctor</li>
  <li>Get Patient -> /api/patient</li>
  <li>Get Appointment -> /api/Appointment</li>
  </ul>
  
![image](https://user-images.githubusercontent.com/83606238/235563147-1b11cec6-208c-4200-8257-f50fcddcfd0c.png)

![image](https://user-images.githubusercontent.com/83606238/235563714-a4524381-92ef-4660-953c-4734274da850.png)

![image](https://user-images.githubusercontent.com/83606238/235563824-644a1f2b-1144-48ff-bc71-4ab0c2afe3e1.png)

<h2>POST:</h2> 
<ul>
  <li>Create Doctor -> /api/doctor</li>
  
  <li>Create Patient -> /api/patient</li>
  
  <li>Get Appointment -> /api/Appointment</li>
  
</ul>


![image](https://user-images.githubusercontent.com/83606238/235563353-956cef3e-6197-4005-858a-ea1bb5a6ef88.png)

![image](https://user-images.githubusercontent.com/83606238/235565432-7c5e9b8e-d8d6-453a-9527-62e9e36c0db3.png)

![image](https://user-images.githubusercontent.com/83606238/235565955-2bc4fe27-891f-405e-b75f-b90400099318.png)





  <h2>DELETE:</h2>  
  
  
  <ul>
  
    <li>Delete Doctor by id -> /api/doctor/id</li>
    
    <li>Delete Patient by Id -> /api/patient/id</li>
    
    <li>Get Appointment -> /api/Appointment/id</li>
  </ul>
  
  ![image](https://user-images.githubusercontent.com/83606238/235563613-3f3c467e-fc15-4eca-b330-146792a6c4b0.png)


  <h2>PUT:</h2> 
  
  ![image](https://user-images.githubusercontent.com/83606238/235565630-89f42ed9-4881-4230-89e1-3861e3a96d1d.png)
  ![image](https://user-images.githubusercontent.com/83606238/235565825-2cd8a189-e476-4483-a825-16e11c274eae.png)



<h1>Sample Request Body:</h1>

see above for Postman
<h1>Sample Response Body:</h1>
see above for Postman

