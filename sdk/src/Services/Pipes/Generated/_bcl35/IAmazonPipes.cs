/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Pipes.Model;

namespace Amazon.Pipes
{
    /// <summary>
    /// Interface for accessing Pipes
    ///
    /// Amazon EventBridge Pipes connects event sources to targets. Pipes reduces the need
    /// for specialized knowledge and integration code when developing event driven architectures.
    /// This helps ensures consistency across your company’s applications. With Pipes, the
    /// target can be any available EventBridge target. To set up a pipe, you select the event
    /// source, add optional event filtering, define optional enrichment, and select the target
    /// for the event data.
    /// </summary>
    public partial interface IAmazonPipes : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPipesPaginatorFactory Paginators { get; }
#endif


        
        #region  CreatePipe


        /// <summary>
        /// Create a pipe. Amazon EventBridge Pipes connect event sources to targets and reduces
        /// the need for specialized knowledge and integration code.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePipe service method.</param>
        /// 
        /// <returns>The response from the CreatePipe service method, as returned by Pipes.</returns>
        /// <exception cref="Amazon.Pipes.Model.ConflictException">
        /// An action you attempted resulted in an exception.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.NotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ServiceQuotaExceededException">
        /// A quota has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ThrottlingException">
        /// An action was throttled.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ValidationException">
        /// Indicates that an error has occurred while performing a validate operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/CreatePipe">REST API Reference for CreatePipe Operation</seealso>
        CreatePipeResponse CreatePipe(CreatePipeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePipe operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePipe operation on AmazonPipesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePipe
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/CreatePipe">REST API Reference for CreatePipe Operation</seealso>
        IAsyncResult BeginCreatePipe(CreatePipeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePipe operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePipe.</param>
        /// 
        /// <returns>Returns a  CreatePipeResult from Pipes.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/CreatePipe">REST API Reference for CreatePipe Operation</seealso>
        CreatePipeResponse EndCreatePipe(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePipe


        /// <summary>
        /// Delete an existing pipe. For more information about pipes, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-pipes.html">Amazon
        /// EventBridge Pipes</a> in the Amazon EventBridge User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePipe service method.</param>
        /// 
        /// <returns>The response from the DeletePipe service method, as returned by Pipes.</returns>
        /// <exception cref="Amazon.Pipes.Model.ConflictException">
        /// An action you attempted resulted in an exception.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.NotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ThrottlingException">
        /// An action was throttled.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ValidationException">
        /// Indicates that an error has occurred while performing a validate operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/DeletePipe">REST API Reference for DeletePipe Operation</seealso>
        DeletePipeResponse DeletePipe(DeletePipeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePipe operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePipe operation on AmazonPipesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePipe
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/DeletePipe">REST API Reference for DeletePipe Operation</seealso>
        IAsyncResult BeginDeletePipe(DeletePipeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePipe operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePipe.</param>
        /// 
        /// <returns>Returns a  DeletePipeResult from Pipes.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/DeletePipe">REST API Reference for DeletePipe Operation</seealso>
        DeletePipeResponse EndDeletePipe(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePipe


        /// <summary>
        /// Get the information about an existing pipe. For more information about pipes, see
        /// <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-pipes.html">Amazon
        /// EventBridge Pipes</a> in the Amazon EventBridge User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePipe service method.</param>
        /// 
        /// <returns>The response from the DescribePipe service method, as returned by Pipes.</returns>
        /// <exception cref="Amazon.Pipes.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.NotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ThrottlingException">
        /// An action was throttled.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ValidationException">
        /// Indicates that an error has occurred while performing a validate operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/DescribePipe">REST API Reference for DescribePipe Operation</seealso>
        DescribePipeResponse DescribePipe(DescribePipeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePipe operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePipe operation on AmazonPipesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePipe
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/DescribePipe">REST API Reference for DescribePipe Operation</seealso>
        IAsyncResult BeginDescribePipe(DescribePipeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePipe operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePipe.</param>
        /// 
        /// <returns>Returns a  DescribePipeResult from Pipes.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/DescribePipe">REST API Reference for DescribePipe Operation</seealso>
        DescribePipeResponse EndDescribePipe(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPipes


        /// <summary>
        /// Get the pipes associated with this account. For more information about pipes, see
        /// <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-pipes.html">Amazon
        /// EventBridge Pipes</a> in the Amazon EventBridge User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPipes service method.</param>
        /// 
        /// <returns>The response from the ListPipes service method, as returned by Pipes.</returns>
        /// <exception cref="Amazon.Pipes.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ThrottlingException">
        /// An action was throttled.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ValidationException">
        /// Indicates that an error has occurred while performing a validate operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/ListPipes">REST API Reference for ListPipes Operation</seealso>
        ListPipesResponse ListPipes(ListPipesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPipes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPipes operation on AmazonPipesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPipes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/ListPipes">REST API Reference for ListPipes Operation</seealso>
        IAsyncResult BeginListPipes(ListPipesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPipes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPipes.</param>
        /// 
        /// <returns>Returns a  ListPipesResult from Pipes.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/ListPipes">REST API Reference for ListPipes Operation</seealso>
        ListPipesResponse EndListPipes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Displays the tags associated with a pipe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Pipes.</returns>
        /// <exception cref="Amazon.Pipes.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.NotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ValidationException">
        /// Indicates that an error has occurred while performing a validate operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonPipesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Pipes.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  StartPipe


        /// <summary>
        /// Start an existing pipe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPipe service method.</param>
        /// 
        /// <returns>The response from the StartPipe service method, as returned by Pipes.</returns>
        /// <exception cref="Amazon.Pipes.Model.ConflictException">
        /// An action you attempted resulted in an exception.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.NotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ThrottlingException">
        /// An action was throttled.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ValidationException">
        /// Indicates that an error has occurred while performing a validate operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/StartPipe">REST API Reference for StartPipe Operation</seealso>
        StartPipeResponse StartPipe(StartPipeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartPipe operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartPipe operation on AmazonPipesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartPipe
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/StartPipe">REST API Reference for StartPipe Operation</seealso>
        IAsyncResult BeginStartPipe(StartPipeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartPipe operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartPipe.</param>
        /// 
        /// <returns>Returns a  StartPipeResult from Pipes.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/StartPipe">REST API Reference for StartPipe Operation</seealso>
        StartPipeResponse EndStartPipe(IAsyncResult asyncResult);

        #endregion
        
        #region  StopPipe


        /// <summary>
        /// Stop an existing pipe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopPipe service method.</param>
        /// 
        /// <returns>The response from the StopPipe service method, as returned by Pipes.</returns>
        /// <exception cref="Amazon.Pipes.Model.ConflictException">
        /// An action you attempted resulted in an exception.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.NotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ThrottlingException">
        /// An action was throttled.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ValidationException">
        /// Indicates that an error has occurred while performing a validate operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/StopPipe">REST API Reference for StopPipe Operation</seealso>
        StopPipeResponse StopPipe(StopPipeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopPipe operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopPipe operation on AmazonPipesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopPipe
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/StopPipe">REST API Reference for StopPipe Operation</seealso>
        IAsyncResult BeginStopPipe(StopPipeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopPipe operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopPipe.</param>
        /// 
        /// <returns>Returns a  StopPipeResult from Pipes.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/StopPipe">REST API Reference for StopPipe Operation</seealso>
        StopPipeResponse EndStopPipe(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified pipe. Tags can help you
        /// organize and categorize your resources. You can also use them to scope user permissions
        /// by granting a user permission to access or change only resources with certain tag
        /// values.
        /// 
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to Amazon Web Services and are interpreted strictly
        /// as strings of characters.
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>TagResource</code> action with a pipe that already has tags.
        /// If you specify a new tag key, this tag is appended to the list of tags associated
        /// with the pipe. If you specify a tag key that is already associated with the pipe,
        /// the new tag value that you specify replaces the previous value for that tag.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a pipe.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Pipes.</returns>
        /// <exception cref="Amazon.Pipes.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.NotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ValidationException">
        /// Indicates that an error has occurred while performing a validate operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonPipesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Pipes.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from the specified pipes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Pipes.</returns>
        /// <exception cref="Amazon.Pipes.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.NotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ValidationException">
        /// Indicates that an error has occurred while performing a validate operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonPipesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Pipes.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePipe


        /// <summary>
        /// Update an existing pipe. When you call <code>UpdatePipe</code>, only the fields that
        /// are included in the request are changed, the rest are unchanged. The exception to
        /// this is if you modify any Amazon Web Services-service specific fields in the <code>SourceParameters</code>,
        /// <code>EnrichmentParameters</code>, or <code>TargetParameters</code> objects. The fields
        /// in these objects are updated atomically as one and override existing values. This
        /// is by design and means that if you don't specify an optional field in one of these
        /// Parameters objects, that field will be set to its system-default value after the update.
        /// 
        ///  <pre><code> &lt;p&gt;For more information about pipes, see &lt;a href=&quot;https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-pipes.html&quot;&gt;
        /// Amazon EventBridge Pipes&lt;/a&gt; in the Amazon EventBridge User Guide.&lt;/p&gt;
        /// </code></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipe service method.</param>
        /// 
        /// <returns>The response from the UpdatePipe service method, as returned by Pipes.</returns>
        /// <exception cref="Amazon.Pipes.Model.ConflictException">
        /// An action you attempted resulted in an exception.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.InternalException">
        /// This exception occurs due to unexpected causes.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.NotFoundException">
        /// An entity that you specified does not exist.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ThrottlingException">
        /// An action was throttled.
        /// </exception>
        /// <exception cref="Amazon.Pipes.Model.ValidationException">
        /// Indicates that an error has occurred while performing a validate operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/UpdatePipe">REST API Reference for UpdatePipe Operation</seealso>
        UpdatePipeResponse UpdatePipe(UpdatePipeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePipe operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePipe operation on AmazonPipesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePipe
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/UpdatePipe">REST API Reference for UpdatePipe Operation</seealso>
        IAsyncResult BeginUpdatePipe(UpdatePipeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePipe operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePipe.</param>
        /// 
        /// <returns>Returns a  UpdatePipeResult from Pipes.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pipes-2015-10-07/UpdatePipe">REST API Reference for UpdatePipe Operation</seealso>
        UpdatePipeResponse EndUpdatePipe(IAsyncResult asyncResult);

        #endregion
        
    }
}