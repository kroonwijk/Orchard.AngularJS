Orchard.AngularJS
=================

All resources distributed as part of the latest stable AngularJS toolkit (by Google) in an Orchard module package.

The package itself can be found in the Orchard gallery at
https://gallery.orchardproject.net/List/Modules/Orchard.Module.Orchard.AngularJS

Currently, the stable 1.2.18 version of AngularJS is included. Please help me keep the distribution up to date to the latest stable version of https://angularjs.org.

Building the package
--------------------
Get the code from this git repository over to your local system:
	git clone https://github.com/kroonwijk/Orchard.AngularJS.git

Copy the content of the repository clone into a locally installed version of Orchard under <orchard base-directory>/modules/Orchard.AngularJS.

From <orchard base-directory>/bin run the Orchard shell:
	orchard

From the Orchard shell, enable the packaging feature:
	orchard> feature enable Orchard.Packaging

Now you can package the module:
	orchard> package create Orchard.AngularJS <choose a directory on your filesystem>

That is all.
