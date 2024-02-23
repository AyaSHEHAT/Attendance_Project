<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
   <xsl:output method="xml" version="1.0" encoding="UTF-8" indent="yes"/>

   <!-- Parameter to receive the selected course name -->
   <xsl:param name="selectedCourseName"/>

   <!-- Template to match Users and filter based on the selected course -->
   <xsl:template match="/">
       <Users>
           <!-- Apply templates only to user elements with matching courseName -->
           <xsl:apply-templates select="Data/Users/user[listOfCourses/courseName = $selectedCourseName]"/>
       </Users>
   </xsl:template>

   <!-- Template to match user -->
   <xsl:template match="user">
       <xsl:copy-of select="."/>
   </xsl:template>

</xsl:stylesheet>
