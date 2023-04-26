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
<h2>POST:</h2>                                                                                                                                                         <ul>
  <li>Create Doctor -> /api/doctor</li>
  
  <li>Create Patient -> /api/patient</li>
  
  <li>Get Appointment -> /api/Appointment</li>
  
</ul>

  <h2>DELETE:</h2>  
  
  
  <ul>
  
    <li>Delete Doctor by id -> /api/doctor/id</li>
    
    <li>Delete Patient by Id -> /api/patient/id</li>
    
    <li>Get Appointment -> /api/Appointment</li>
  </ul>

<h1>Sample Request Body:</h1>
 <h2>Post:</h2>
  {
  {"appointmentId":4,
  "date":"2023-04-27T00:00:00",
  "startTime":"10:00:00",
  "endTime":"10:30:00",
  "doctorId":1,
  "patientId":1,
  "doctor":null,
  "patient":null}]

<h1>Sample Response Body:</h1>
  <h2>201 created</h2>
    {"patientId":1,
    "name":"Jane Doe",
    "age":35,"
    gender":"Female",
  "email":"jane.doe@email.com",
  "phoneNumber":"555-5678"}
