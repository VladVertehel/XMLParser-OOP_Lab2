<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="/">
    <html>
      <head>
        <title>Успішність студентів</title>
      </head>
      <body>
        <h1>Успішність студентів КНУ ім. Тараса Шевченка</h1>
        <xsl:apply-templates/>
      </body>
    </html>
  </xsl:template>

  <xsl:template match="university">
    <xsl:apply-templates/>
  </xsl:template>

  <xsl:template match="faculty">
    <h2><xsl:value-of select="@name"/></h2>
    <xsl:apply-templates/>
  </xsl:template>

  <xsl:template match="department">
    <h3><xsl:value-of select="@name"/></h3>
    <xsl:apply-templates/>
  </xsl:template>

  <xsl:template match="discipline">
    <h4><xsl:value-of select="@name"/></h4>
    <table border="1">
      <tr>
        <th>Студент</th>
        <th>Оцінка</th>
      </tr>
      <xsl:apply-templates select="student"/>
    </table>
  </xsl:template>

  <xsl:template match="student">
    <tr>
      <td><xsl:value-of select="@name"/></td>
      <td><xsl:value-of select="@grade"/></td>
    </tr>
  </xsl:template>

</xsl:stylesheet>