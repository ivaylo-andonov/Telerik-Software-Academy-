<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/school">
    <html>
      <style>
        dt {
        font-weight:bold;
        }
      </style>
      <body>
        <h1 style="background-color:yellow; border-radius:10px">Telerik Academy Kids</h1>
        <h3>Students: </h3>
        <div>
          <xsl:for-each select="students/student">
            <dl>
              <dt>
                Name of Student:
              </dt>
              <dd>
                <xsl:value-of select="name"/>
              </dd>
              <dt>
                Gender:
              </dt>
              <dd>
                <xsl:value-of select="sex"/>
              </dd>
              <dt>
                Date of Birth:
              </dt>
              <dd>
                <xsl:value-of select="birthdate"/>
              </dd>
              <dt>
                Phone Number:
              </dt>
              <dd>
                <xsl:value-of select="phone"/>
              </dd>
              <dt>
                Email:
              </dt>
              <dd>
                <xsl:value-of select="email"/>
              </dd>
              <dt>
                Current Course:
              </dt>
              <dd>
                <xsl:value-of select="course"/>
              </dd>
              <dt>
                Specialty:
              </dt>
              <dd>
                <xsl:value-of select="specialty"/>
              </dd>
              <dt>
                Faculty Number:
              </dt>
              <dd>
                <xsl:value-of select="name"/>
              </dd>
              <dt>
                <hr></hr>
                Passed Exams:
              </dt>
              <dd>
                <dl>
                  <xsl:for-each select="passedexams/exam">
                    <dt>Course: </dt>
                    <dd>
                      <xsl:value-of select="course"/>
                    </dd>
                    <dt>Tutor: </dt>
                    <dd>
                      <xsl:value-of select="tutor"/>
                    </dd>
                    <dt>Score: </dt>
                    <dd>
                      <xsl:value-of select="score"/>
                    </dd>
                  </xsl:for-each>
                </dl>
              </dd>
            </dl>
            <hr style="height:8px; background-color:black"></hr>
          </xsl:for-each>
        </div>
        <h3>Enrollment Dates:</h3>
        <div>
          <xsl:for-each select="enrollment/dates/date">
            <p>
              <xsl:value-of select="day"/>
            </p>
          </xsl:for-each>
          <p>
            Exam score: <xsl:value-of select="enrollment/examscore"/>
          </p>
        </div>
        <h3>Teacher Endorsements:</h3>
        <div>
          <xsl:for-each select="teachers/teacher">
            <p>
              <xsl:value-of select="name"/> - <xsl:value-of select="endorsement" />
            </p>
          </xsl:for-each>
        </div>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
