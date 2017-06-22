require "ruby/csharp_script/version"
require 'win32ole'

module Ruby
  module CSharpScript
    class CSharpScript
      attr_reader :csharp_script
      def initialize
        @csharp_script = WIN32OLE.new("ruby.csharp_script.CSharpScript")
      end
      
      def evaluate_async(code)
        @csharp_script.EvaluateAsync(code)
      end
    end
  end
end
