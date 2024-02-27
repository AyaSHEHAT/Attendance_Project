<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<!-- Define parameters -->
	<xsl:param name="selectedCourseName" select="''"/>
	<xsl:param name="selectedDate" select="''"/>
	<!-- Template to match users -->
	<xsl:template match="user">
		<!-- Check if the user has the selected course in their list of courses -->
		<xsl:if test="listOfCourses/courseName = $selectedCourseName">
			<!-- Retrieve user information -->
			<xsl:variable name="userId" select="id"/>
			<xsl:variable name="userName" select="name"/>
			<!-- Search for the chosen course in the Courses section -->
			<xsl:for-each select="//Courses/course[cName = $selectedCourseName]">
				<!-- Iterate through sessions of the chosen course -->
				<xsl:for-each select="sessions/session[date = $selectedDate]">
					<!-- Iterate through students of the session -->
					<xsl:for-each select="students/student[stdId = $userId]">
						<!-- Display information -->
						<tr>
							<td>
								<xsl:value-of select="$userId"/>
							</td>
							<td>
								<xsl:value-of select="$userName"/>
							</td>
							<td>
								<xsl:value-of select="$selectedDate"/>
							</td>
							<td>
								<xsl:value-of select="ancestor::course/cName"/>
							</td>
							<td>
								<xsl:value-of select="status"/>
							</td>
						</tr>
					</xsl:for-each>
				</xsl:for-each>
			</xsl:for-each>
		</xsl:if>
	</xsl:template>
	<!-- Template to match the root element -->
	<xsl:template match="/">
		<html>
			<head>
				<title>Attendance Report</title>
			</head>
			<body>
				<h2>Attendance Report for <xsl:value-of select="$selectedCourseName"/>
				</h2>
				<table border="1">
					<tr>
						<th>Student ID</th>
						<th>Student Name</th>
						<th>Date</th>
						<th>Course Name</th>
						<th>Status</th>
					</tr>
					<!-- Apply transformation to users -->
					<xsl:apply-templates select="//user"/>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
