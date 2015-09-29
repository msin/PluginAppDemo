# PluginAppDemo
Shell App Demo with dynamic plugins registration

Based on SimpleInjector IoC and DevExpress WPF components.
https://simpleinjector.readthedocs.org/en/latest/quickstart.html

Plugin projects do not depend on Shell project.
So you have to Build Solution (F6) after plugin modification
A plugin project has a post-build event with command:
  copy /Y "$(TargetPath)" "$(SolutionDir)\$(SolutionName)\$(OutDir)"
