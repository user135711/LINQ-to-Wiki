using System.Collections.Generic;
using LinqToWiki;
using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinqToWiki.Internals;
using LinqToWiki.Download;
// <copyright file="DownloaderTest.Constructor.g.cs">Copyright ©  2011</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace LinqToWiki.Download.Tests
{
    public partial class DownloaderTest
    {

[TestMethod]
[PexGeneratedBy(typeof(DownloaderTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ConstructorThrowsArgumentNullException199()
{
    Downloader downloader;
    downloader = this.Constructor((WikiInfo)null);
}

[TestMethod]
[PexGeneratedBy(typeof(DownloaderTest))]
public void Constructor205()
{
    WikiInfo wikiInfo;
    Downloader downloader;
    Namespace[] namespaces = new Namespace[0];
    wikiInfo = WikiInfoFactory.Create
                   ("\0", (string)null, (string)null, (IEnumerable<Namespace>)namespaces);
    downloader = this.Constructor(wikiInfo);
    Assert.IsNotNull((object)downloader);
}

[TestMethod]
[PexGeneratedBy(typeof(DownloaderTest))]
public void Constructor948()
{
    WikiInfo wikiInfo;
    Downloader downloader;
    Namespace[] namespaces = new Namespace[0];
    wikiInfo = WikiInfoFactory.Create
                   ("", " ##\0", (string)null, (IEnumerable<Namespace>)namespaces);
    downloader = this.Constructor(wikiInfo);
    Assert.IsNotNull((object)downloader);
}

[TestMethod]
[PexGeneratedBy(typeof(DownloaderTest))]
public void Constructor94801()
{
    WikiInfo wikiInfo;
    Downloader downloader;
    Namespace[] namespaces = new Namespace[0];
    wikiInfo = WikiInfoFactory.Create
                   ("", (string)null, "", (IEnumerable<Namespace>)namespaces);
    downloader = this.Constructor(wikiInfo);
    Assert.IsNotNull((object)downloader);
}

[TestMethod]
[PexGeneratedBy(typeof(DownloaderTest))]
public void Constructor94802()
{
    WikiInfo wikiInfo;
    Downloader downloader;
    Namespace[] namespaces = new Namespace[0];
    wikiInfo = WikiInfoFactory.Create
                   ("", "†##", (string)null, (IEnumerable<Namespace>)namespaces);
    downloader = this.Constructor(wikiInfo);
    Assert.IsNotNull((object)downloader);
}

[TestMethod]
[PexGeneratedBy(typeof(DownloaderTest))]
public void Constructor94803()
{
    object o;
    WikiInfo wikiInfo;
    Downloader downloader;
    o = NamespaceFactory.Create(0);
    Namespace[] namespaces = new Namespace[1];
    namespaces[0] = (Namespace)o;
    wikiInfo = WikiInfoFactory.Create
                   ("", " #￾", (string)null, (IEnumerable<Namespace>)namespaces);
    downloader = this.Constructor(wikiInfo);
    Assert.IsNotNull((object)downloader);
}

[TestMethod]
[PexGeneratedBy(typeof(DownloaderTest))]
public void Constructor246()
{
    object o;
    WikiInfo wikiInfo;
    Downloader downloader;
    o = NamespaceFactory.Create(645);
    Namespace[] namespaces = new Namespace[1];
    namespaces[0] = (Namespace)o;
    wikiInfo = WikiInfoFactory.Create
                   ("", " #￾(", (string)null, (IEnumerable<Namespace>)namespaces);
    downloader = this.Constructor(wikiInfo);
    Assert.IsNotNull((object)downloader);
}
    }
}
