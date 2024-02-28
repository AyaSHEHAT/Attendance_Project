<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:param name="selectedCourseName" select="''"/>
    <xsl:param name="userID" select="''"/>

    <!-- Define CSS styles -->
    <xsl:variable name="styles">
        <style type="text/css">
            .attendance-report {
                font-family: Arial, sans-serif;
                border-collapse: collapse;
                width: 100%;
            }
            .attendance-report th, .attendance-report td {
                border: 1px solid #dddddd;
                text-align: left;
                padding: 8px;
            }
            .attendance-report th {
                background-color: #f2f2f2;
            }
        </style>
    </xsl:variable>

    <xsl:output method="html" indent="yes"/>

    <!-- Match the root element -->
    <xsl:template match="/">
        <!-- HTML root element -->
        <html lang="en">
        <head>
            <meta charset="UTF-8"/>
            <title>Attendance Report</title>
            <!-- Apply CSS styles -->
            <xsl:copy-of select="$styles"/>
        </head>
        <body>
            <!-- Attendance report -->
            <div class="attendance-report">
                <h2>Attendance Report</h2>
                <!-- Apply templates to the selected course -->
                <xsl:apply-templates select="//course[cName = $selectedCourseName]"/>
            </div>
        </body>
        </html>
    </xsl:template>

    <!-- Template for course elements -->
    <xsl:template match="course">
        <xsl:variable name="courseID" select="cID"/>
        <xsl:variable name="courseName" select="cName"/>
        <div class="course">
            <h3>Course ID: <xsl:value-of select="$courseID"/></h3>
            <h4>Course Name: <xsl:value-of select="$courseName"/></h4>
            <!-- Extract session information for the selected course and user ID -->
            <table class="sessions">
                <thead>
                    <tr>
                        <th>Session Number</th>
                        <th>Date</th>
                        <th>Status</th>
                    </tr>
                </thead>
                <tbody>
                    <xsl:apply-templates select="sessions/session[students/student[stdId = $userID]]"/>
                </tbody>
            </table>
        </div>
    </xsl:template>

    <!-- Template for session elements -->
    <xsl:template match="session">
        <tr>
            <!-- Extract the session number -->
            <td><xsl:value-of select="sessionNum"/></td>
            <!-- Extract the session date -->
            <td><xsl:value-of select="date"/></td>
            <!-- Extract the session status -->
            <td><xsl:value-of select="students/student[stdId = $userID]/status"/></td>
        </tr>
    </xsl:template>
</xsl:stylesheet>
