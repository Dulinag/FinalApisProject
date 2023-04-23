# FinalApisProject

This is a simple web application that allows users to manage patients, doctors, and appointments through a RESTful API. The application was built using C# and the Entity Framework Core, which provides an object-relational mapping (ORM) between the C# code and the SQL database. The application includes controller files for each entity (patient, doctor, appointment), which handle HTTP requests and responses, such as GET, POST, PUT, and DELETE.

The Patients table contains information about patients, including their name, date of birth, gender, address, phone number, and email. The Doctors table contains information about doctors, including their name, specialization, phone number, and email. The Appointments table connects patients and doctors, with information about the appointment date and type.

The application uses a MySQL database, which is configured in the MyFirstAPIDBContext class. The connection string is stored in the appsettings.json file, which can be modified to point to a different database.

The API can be tested using an HTTP client, such as Postman
