<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
   <xsl:output method="html" version="1.0" encoding="UTF-8" indent="yes"/>

   <!-- Parameter to receive the selected course name -->
   <xsl:param name="selectedCourseName" select="''"/>

   <!-- Template to match Users and filter based on the selected course -->
   <xsl:template match="/">
       <html>
           <head>
               <style>
                   table, th, td {
                       border: 1px solid black;
                       border-collapse: collapse;
                       padding: 5px;
                   }
               </style>
           </head>
           <body>
               <h2>Users for Course: <xsl:value-of select="$selectedCourseName"/></h2>
               <table>
                   <tr>
                       <th>user</th>
                       <th>Name</th>
                       <th>Email</th>
                       <th>Address</th>
                       <th>Role</th>
                   </tr>
                   <!-- Apply templates only to user elements with matching courseName -->
                   <xsl:apply-templates select="Data/Users/user[listOfCourses/courseName = $selectedCourseName]"/>
               </table>
           </body>
       </html>
   </xsl:template>

   <!-- Template to match user -->
   <xsl:template match="user">
       <tr>
           <td><xsl:value-of select="id"/></td>
           <td><xsl:value-of select="name"/></td>
           <td><xsl:value-of select="email"/></td>
           <td><xsl:value-of select="address"/></td>
           <td><xsl:value-of select="role"/></td>
       </tr>
   </xsl:template>

</xsl:stylesheet>
