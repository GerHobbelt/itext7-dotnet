using System;
using Java.IO;
using NUnit.Framework;

namespace iTextSharp.Kernel.Utils
{
	public class CompareToolTest
	{
		public const String sourceFolder = "../../resources/itextsharp/kernel/utils/CompareToolTest/";

		public const String destinationFolder = "test/itextsharp/kernel/utils/CompareToolTest/";

		[SetUp]
		public virtual void SetUp()
		{
			File dest = new File(destinationFolder);
			dest.Mkdirs();
			File[] files = dest.ListFiles();
			if (files != null)
			{
				foreach (File file in files)
				{
					file.Delete();
				}
			}
		}

		/// <exception cref="System.Exception"/>
		/// <exception cref="System.IO.IOException"/>
		/// <exception cref="Javax.Xml.Parsers.ParserConfigurationException"/>
		/// <exception cref="Org.Xml.Sax.SAXException"/>
		[Test]
		public virtual void CompareToolErrorReportTest01()
		{
			CompareTool compareTool = new CompareTool();
			compareTool.SetCompareByContentErrorsLimit(10);
			compareTool.SetGenerateCompareByContentXmlReport(true);
			String outPdf = sourceFolder + "simple_pdf.pdf";
			String cmpPdf = sourceFolder + "cmp_simple_pdf.pdf";
			String result = compareTool.CompareByContent(outPdf, cmpPdf, destinationFolder, "difference"
				);
			System.Console.Out.WriteLine(result);
			NUnit.Framework.Assert.IsNotNull("CompareTool must return differences found between the files"
				, result);
			// Comparing the report to the reference one.
			NUnit.Framework.Assert.IsTrue(compareTool.CompareXmls(sourceFolder + "cmp_report01.xml"
				, destinationFolder + "report.xml"), "CompareTool report differs from the reference one"
				);
		}

		/// <exception cref="System.IO.IOException"/>
		/// <exception cref="System.Exception"/>
		/// <exception cref="Javax.Xml.Parsers.ParserConfigurationException"/>
		/// <exception cref="Org.Xml.Sax.SAXException"/>
		[Test]
		public virtual void CompareToolErrorReportTest02()
		{
			CompareTool compareTool = new CompareTool();
			compareTool.SetCompareByContentErrorsLimit(10);
			compareTool.SetGenerateCompareByContentXmlReport(true);
			String outPdf = sourceFolder + "tagged_pdf.pdf";
			String cmpPdf = sourceFolder + "cmp_tagged_pdf.pdf";
			String result = compareTool.CompareByContent(outPdf, cmpPdf, destinationFolder, "difference"
				);
			System.Console.Out.WriteLine(result);
			NUnit.Framework.Assert.IsNotNull("CompareTool must return differences found between the files"
				, result);
			// Comparing the report to the reference one.
			NUnit.Framework.Assert.IsTrue(compareTool.CompareXmls(sourceFolder + "cmp_report02.xml"
				, destinationFolder + "report.xml"), "CompareTool report differs from the reference one"
				);
		}

		/// <exception cref="System.Exception"/>
		/// <exception cref="System.IO.IOException"/>
		/// <exception cref="Javax.Xml.Parsers.ParserConfigurationException"/>
		/// <exception cref="Org.Xml.Sax.SAXException"/>
		[Test]
		public virtual void CompareToolErrorReportTest03()
		{
			CompareTool compareTool = new CompareTool();
			compareTool.SetCompareByContentErrorsLimit(10);
			compareTool.SetGenerateCompareByContentXmlReport(true);
			String outPdf = sourceFolder + "screenAnnotation.pdf";
			String cmpPdf = sourceFolder + "cmp_screenAnnotation.pdf";
			String result = compareTool.CompareByContent(outPdf, cmpPdf, destinationFolder, "difference"
				);
			System.Console.Out.WriteLine(result);
			NUnit.Framework.Assert.IsNotNull("CompareTool must return differences found between the files"
				, result);
			// Comparing the report to the reference one.
			NUnit.Framework.Assert.IsTrue(compareTool.CompareXmls(sourceFolder + "cmp_report03.xml"
				, destinationFolder + "report.xml"), "CompareTool report differs from the reference one"
				);
		}
	}
}
