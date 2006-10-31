#!/bin/bash
cd sdk
rm -R TestDataFiles file_formats interface_docs java \
 libraries_and_tools parser_examples sample_data *.html *.gif \
 portability/CPPTest file/CPPTest calvin_files/makefile.g5 \
 calvin_files/template/test\
 calvin_files/array/test\
 calvin_files/data/test calvin_files/data/data\
 calvin_files/exception/test\
 calvin_files/fusion/test calvin_files/fusion/data\
 calvin_files/fusion/com\
 calvin_files/fusion/swig-cs calvin_files/fusion/swig-perl\
 calvin_files/parameter/test\
 calvin_files/parsers/test calvin_files/parsers/data\
 calvin_files/portability/test\
 calvin_files/utils/test calvin_files/utils/data\
 calvin_files/writers/test calvin_files/writers/data
cd -
diff -rq sdk /Users/kdh/Work/bioc/affxparser/src/fusion_sdk | grep Only | grep -v svn


